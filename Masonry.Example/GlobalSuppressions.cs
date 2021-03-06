#region License

/*
 Copyright 2013 - 2016 Nikita Bernthaler
 GlobalSuppressions.cs is part of Masonry.Example.

 Masonry.Example is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 Masonry.Example is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with Masonry.Example. If not, see <http://www.gnu.org/licenses/>.
*/

#endregion License

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member",
        Target = "Masonry.Example.ViewModels.MainViewModel.#.ctor()")]
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.