using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D323 - .
/// </summary>
public class F80D323 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GEMGRP.
        /// </summary>
        public const string GEMGRP = "GEMGRP";

        /// <summary>
        /// GEGEMAIL.
        /// </summary>
        public const string GEGEMAIL = "GEGEMAIL";

        /// <summary>
        /// GEURCD.
        /// </summary>
        public const string GEURCD = "GEURCD";

        /// <summary>
        /// GEURDT.
        /// </summary>
        public const string GEURDT = "GEURDT";

        /// <summary>
        /// GEURAT.
        /// </summary>
        public const string GEURAT = "GEURAT";

        /// <summary>
        /// GEURAB.
        /// </summary>
        public const string GEURAB = "GEURAB";

        /// <summary>
        /// GEURRF.
        /// </summary>
        public const string GEURRF = "GEURRF";

        /// <summary>
        /// GEUSER.
        /// </summary>
        public const string GEUSER = "GEUSER";

        /// <summary>
        /// GEMKEY.
        /// </summary>
        public const string GEMKEY = "GEMKEY";

        /// <summary>
        /// GEPID.
        /// </summary>
        public const string GEPID = "GEPID";

        /// <summary>
        /// GEUUPMJ.
        /// </summary>
        public const string GEUUPMJ = "GEUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D323";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GEMGRP", "GEMGRP", JdeDataType.String, 10, true, true),
        new JdeField("GEGEMAIL", "GEGEMAIL", JdeDataType.String, 512),
        new JdeField("GEURCD", "GEURCD", JdeDataType.String, 4),
        new JdeField("GEURDT", "GEURDT", JdeDataType.Numeric),
        new JdeField("GEURAT", "GEURAT", JdeDataType.Numeric),
        new JdeField("GEURAB", "GEURAB", JdeDataType.Numeric),
        new JdeField("GEURRF", "GEURRF", JdeDataType.String, 30),
        new JdeField("GEUSER", "GEUSER", JdeDataType.String, 20),
        new JdeField("GEMKEY", "GEMKEY", JdeDataType.String, 30),
        new JdeField("GEPID", "GEPID", JdeDataType.String, 20),
        new JdeField("GEUUPMJ", "GEUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D323_0", "Primary Key on GEMGRP", new[] { "GEMGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
