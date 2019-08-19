class Admin::BaseController < ActionController::Base
before_action :authenticate_admin!
layout 'admin'

def index
  @posts = Post.all 
  @projects = Project.all
end

def show
  @posts = Post.find(params[:id])
  @projects = Project.find(params[:id])
end


end
