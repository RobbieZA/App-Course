import { HomeComponent } from './home/home.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { UserListComponent } from './users/user-list/user-list.component';
import { Routes } from '@angular/router';
import { AuthGuard } from './_guards/auth.guard';
import { UserDetailComponent } from './users/user-detail/user-detail.component';
import { UserDetailResolver } from './_resolvers/user-detail.resolver';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'users', component: UserListComponent, resolve: {users: UserListComponent}},
            {path: 'users/:id', component: UserDetailComponent, resolve: {user: UserDetailResolver}},
            {path: 'messages', component: MessagesComponent},
            {path: 'lists', component: ListsComponent}
        ]
    },
    {path: 'users', component: UserListComponent, canActivate: [AuthGuard]},
    {path: 'messages', component: MessagesComponent},
    {path: 'lists', component: ListsComponent},
    {path: '**', redirectTo: 'home', pathMatch: 'full'}
];
