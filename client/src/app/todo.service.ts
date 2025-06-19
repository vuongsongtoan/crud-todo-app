import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Todo {
  id: string; // GUID
  title: string;
  description?: string;
  isCompleted: boolean;
}

@Injectable({ providedIn: 'root' })
export class TodoService {
  private apiUrl = 'http://localhost:5014/api/Todos'; // Lấy từ launchSettings.json, profile http/https

  constructor(private http: HttpClient) {}

  getTodos(): Observable<Todo[]> {
    return this.http.get<Todo[]>(this.apiUrl);
  }

  getTodo(id: string): Observable<Todo> {
    return this.http.get<Todo>(`${this.apiUrl}/${id}`);
  }

  createTodo(todo: Partial<Todo>): Observable<Todo> {
    // Không gửi id khi tạo mới
    const { id, ...data } = todo;
    return this.http.post<Todo>(this.apiUrl, data);
  }

  updateTodo(todo: Todo): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${todo.id}`, todo);
  }

  deleteTodo(id: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
