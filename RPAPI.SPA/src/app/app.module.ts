import { UserListComponent } from './users/user-list/user-list.component';
import { UserDetailComponent } from './users/user-detail/user-detail.component';
import { UserCardComponent } from './users/user-card/user-card.component';
import { HttpClientModule } from '@angular/common/http';
import { UserListResolver } from './_resolvers/user-list.resolver';
import { UserDetailResolver } from './_resolvers/user-detail.resolver';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {HttpModule} from '@angular/http';
import { BsDropdownModule, TabsModule } from 'ngx-bootstrap';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AlertifyService } from './_services/alertify.service';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';
import { AuthGuard } from './_guards/auth.guard';
import { UserService } from './_services/user.service';
import { AuthModule } from './auth/auth.module';
import { NgxGalleryModule } from 'ngx-gallery';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    UserListComponent,
    ListsComponent,
    MessagesComponent,
    UserCardComponent,
    UserDetailComponent
],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    RouterModule.forRoot(appRoutes),
    AuthModule,
    TabsModule.forRoot(),
    NgxGalleryModule,
    HttpClientModule
  ],
  providers: [
    AuthService,
    AlertifyService,
    AuthGuard,
    UserService,
    UserListResolver,
    UserDetailResolver,
    HttpClientModule
  ],
    bootstrap: [AppComponent]
})
export class AppModule { }
