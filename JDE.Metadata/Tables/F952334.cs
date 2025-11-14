using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952334 - .
/// </summary>
public class F952334 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRURLOBID.
        /// </summary>
        public const string PRURLOBID = "PRURLOBID";

        /// <summary>
        /// PRURLOBNM.
        /// </summary>
        public const string PRURLOBNM = "PRURLOBNM";

        /// <summary>
        /// PRURLOBDSC.
        /// </summary>
        public const string PRURLOBDSC = "PRURLOBDSC";

        /// <summary>
        /// PRURLUSER.
        /// </summary>
        public const string PRURLUSER = "PRURLUSER";

        /// <summary>
        /// PRURLXML.
        /// </summary>
        public const string PRURLXML = "PRURLXML";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRMKEY.
        /// </summary>
        public const string PRMKEY = "PRMKEY";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";

        /// <summary>
        /// PRURLFU1.
        /// </summary>
        public const string PRURLFU1 = "PRURLFU1";

        /// <summary>
        /// PRURLFU2.
        /// </summary>
        public const string PRURLFU2 = "PRURLFU2";

        /// <summary>
        /// PRURLFU3.
        /// </summary>
        public const string PRURLFU3 = "PRURLFU3";

        /// <summary>
        /// PRURLFU4.
        /// </summary>
        public const string PRURLFU4 = "PRURLFU4";

        /// <summary>
        /// PRURLFU5.
        /// </summary>
        public const string PRURLFU5 = "PRURLFU5";

        /// <summary>
        /// PRURLFU6.
        /// </summary>
        public const string PRURLFU6 = "PRURLFU6";

        /// <summary>
        /// PRURLFU7.
        /// </summary>
        public const string PRURLFU7 = "PRURLFU7";

        /// <summary>
        /// PRURLFU8.
        /// </summary>
        public const string PRURLFU8 = "PRURLFU8";
    }

    /// <inheritdoc />
    public override string TableName => "F952334";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRURLOBID", "PRURLOBID", JdeDataType.String, 140, true, true),
        new JdeField("PRURLOBNM", "PRURLOBNM", JdeDataType.String, 60),
        new JdeField("PRURLOBDSC", "PRURLOBDSC", JdeDataType.String, 200),
        new JdeField("PRURLUSER", "PRURLUSER", JdeDataType.String, 20),
        new JdeField("PRURLXML", "PRURLXML", JdeDataType.String),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRMKEY", "PRMKEY", JdeDataType.String, 30),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric),
        new JdeField("PRURLFU1", "PRURLFU1", JdeDataType.String, 2),
        new JdeField("PRURLFU2", "PRURLFU2", JdeDataType.String, 2),
        new JdeField("PRURLFU3", "PRURLFU3", JdeDataType.String, 60),
        new JdeField("PRURLFU4", "PRURLFU4", JdeDataType.String, 60),
        new JdeField("PRURLFU5", "PRURLFU5", JdeDataType.Numeric),
        new JdeField("PRURLFU6", "PRURLFU6", JdeDataType.Numeric),
        new JdeField("PRURLFU7", "PRURLFU7", JdeDataType.String, 500),
        new JdeField("PRURLFU8", "PRURLFU8", JdeDataType.String, 500)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952334_0", "Primary Key on PRURLOBID", new[] { "PRURLOBID" }, isUnique: true, isPrimaryKey: true)
    };
}
