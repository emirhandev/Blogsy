# Blogsy 

## Project Overview
Blogsy is a personal blog application built with ASP.NET Core. It allows users to view and interact with blog posts, authors, and categories.

## User Access:
View Published Blogs: Users can browse the titles and subtitles of all published blogs, providing a quick overview of available content.
Read Full Blog Content: By clicking on a blog title, users can access the full content of the blog post, including detailed text and images.
List All Blogs: Users can view a comprehensive list of all published blogs, allowing for easy navigation and discovery of content.
Access Blogs by Author: Users can filter and access blogs based on the author, enabling them to view all posts by a specific writer. This feature enhances the user experience by allowing them to explore content from their favorite authors.

## Architecture
The application is structured using the MVC (Model-View-Controller) pattern, consisting of:
Models: Define the data structure.
Views: Render the user interface.
Controllers: Handle user input and interact with models.

## Models
- Author
- Blog
- Category


## Views
- Index View: Displays a summary of the latest blog posts.
- All Posts View: Lists all published posts with pagination.
- Authors View: Lists authors with links to their posts.
- Post View: Shows the full content of a selected blog post.

## Controllers
HomeController
Handles requests for the home page, all posts, authors, and individual blog posts.

Key actions include:

- Index(): Displays the latest published blog posts.
- AllPosts(): Displays all published blog posts.
- Authors(): Lists all authors.
- AuthorPosts(int Id): Displays posts by a specific author.
- Post(int Id): Displays a specific blog post.

## Home Page
![Home Page](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/1.png)<br/>

![Home Page](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/2.png)<br/>

## Blog Page
![Blog Page](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/3.png)<br/>

## Blog Details
![Blog Details](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/4.png)<br/>

## Blog Details
![Blog Details](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/5.png)<br/>

## Authors Page
![Authors Page](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/6.png)<br/>

## Authors Blogs
![Authors Blogs](https://github.com/emirhandev/Blogsy/blob/main/EmirhanBlog/Images/7.png)<br/>

## Getting Started
To run this project locally, follow these steps:
> Clone the repository:

    git clone https://github.com/emirhandev/Blogsy.git

> Navigate to the project directory:

    cd EmirhanBlog


> Install dependencies:

    dotnet restore

> Run the application:

    dotnet run

Visit http://localhost:5000 in your browser.



