import {Injectable} from '@angular/core';
import {HttpClient, HttpEvent} from '@angular/common/http';
import {Observable} from 'rxjs';
import {catchError, map} from 'rxjs/operators';

@Injectable()
export class BaseApiService {
  private baseUrl = 'https://localhost:44374/api';

  constructor(public httpClient: HttpClient) {
  }

  private getUrl(url: string = ''): string {
    return this.baseUrl + url;
  }

  public get<T>(url: string = '', headers?): Observable<HttpEvent<T>> {
    return this.httpClient.get<T>(this.getUrl(url), headers);
  }
  public request<T>(url: string = '', headers?): Observable<HttpEvent<T>> {
    return this.httpClient.request<T>('get', this.getUrl(url), headers);
  }

  public post<T>(url: string = '', data?): Observable<T> {
    return this.httpClient.post<T>(this.getUrl(url), data);
  }

  public put(url: string = '', data: any = {}): Observable<any> {
    return this.httpClient.put(this.getUrl(url), data).pipe(
      map((response) => response),
      catchError((err) => {
        return "_KC";
      })
    );
  }
}

