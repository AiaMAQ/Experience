Rails.application.routes.draw do
  devise_for :admins
 devise_for :users
 resources :posts
 resources :projects
 resources :contacts, only: [:new, :create]
 get 'welcome/index'
 root 'welcome#index'
 #get '*path' => redirect('/')

namespace :admin do

  root  'base#index'

  delete '/admin/projects/:id' => 'admin/projects#destroy'
  
  resources :posts, only: [:create, :index, :update, :destroy, :edit, :show]
  resources :projects, only: [:create, :index, :update, :destroy, :edit, :show]
end

end
