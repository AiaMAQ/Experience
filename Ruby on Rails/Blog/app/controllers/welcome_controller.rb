class WelcomeController < ApplicationController
  before_action :authenticate_user!

  def index
    @posts = current_user.posts.limit(3).order("created_at desc")
    @projects = current_user.projects.limit(3).order("created_at desc")
  end


end
