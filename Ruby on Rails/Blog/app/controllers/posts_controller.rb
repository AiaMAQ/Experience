class PostsController < ApplicationController
  
  before_action :authenticate_user!

  def index
    @posts = current_user.posts.order("created_at desc").paginate(page: params[:page], per_page: 2)
    
  end

  def new
    @post = Post.new
  end

  def create
    @post = Post.new post_params
    @post.user = current_user
    if @post.save
      redirect_to @post, notice: "Post is created sucessfully!"

    else
      render 'new', notice: "It's unable to be saved"
    end
  end

  def show
    post
  end

  def edit
    @post = current_user.posts.find(params[:id])
  end

  def update
    if post.update post_params
      redirect_to @post, notice: "The article was sucessfully"
    else
      render 'edit'
    end
  end

  def destroy
    post.destroy
    redirect_to posts_path
  end

  

protected 

  def post_params
    params.require(:post).permit(:title, :content)
  end

  def post
    @post ||= current_user.posts.find(params[:id])
  end
end
