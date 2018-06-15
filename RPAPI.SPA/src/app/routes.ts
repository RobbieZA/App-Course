import { HomeComponent } from './home/home.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { UserListComponent } from './user-list/user-list.component';
import { Routes } from '@angular/router';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'users', component: UserListComponent},
            {path: 'messages', component: MessagesComponent},
            {path: 'list', component: ListsComponent}
        ]
    },
    {path: 'users', component: UserListComponent, canActivate: [AuthGuard]},
    {path: 'messages', component: MessagesComponent},
    {path: 'list', component: ListsComponent},
    {path: '**', redirectTo: 'home', pathMatch: 'full'}
];
