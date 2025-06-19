import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { TodoService, Todo } from '../services/todo.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-todo-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css'],
})
export class TodoListComponent implements OnInit {
  newTodo: string = '';
  todos$: Observable<Todo[]>;
  editingId: string | null = null;
  editingTitle: string = '';

  private todoService = inject(TodoService);

  constructor() {
    this.todos$ = this.todoService.getTodos();
  }

  ngOnInit() {
    this.todos$ = this.todoService.getTodos();
  }

  addTodo() {
    if (this.newTodo.trim()) {
      this.todoService.createTodo({ title: this.newTodo.trim(), isCompleted: false }).subscribe(() => {
        this.todos$ = this.todoService.getTodos();
        this.newTodo = '';
      });
    }
  }

  toggleComplete(todo: Todo) {
    this.todoService.updateTodo({ ...todo, isCompleted: !todo.isCompleted }).subscribe(() => {
      this.todos$ = this.todoService.getTodos();
    });
  }

  deleteTodo(todo: Todo) {
    this.todoService.deleteTodo(todo.id).subscribe(() => {
      this.todos$ = this.todoService.getTodos();
    });
  }

  startEdit(todo: Todo) {
    this.editingId = todo.id;
    this.editingTitle = todo.title;
  }

  saveEdit(todo: Todo) {
    if (this.editingTitle.trim() && this.editingTitle !== todo.title) {
      this.todoService.updateTodo({ ...todo, title: this.editingTitle }).subscribe(() => {
        this.todos$ = this.todoService.getTodos();
        this.editingId = null;
        this.editingTitle = '';
      });
    } else {
      this.editingId = null;
      this.editingTitle = '';
    }
  }

  getVietNamTime(dateStr: string): Date {
    const date = new Date(dateStr);
    // Nếu dateStr đã là UTC, cộng thêm 7 tiếng để ra giờ Việt Nam
    return new Date(date.getTime() + 7 * 60 * 60 * 1000);
  }
}
