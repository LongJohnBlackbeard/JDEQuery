using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A20 - .
/// </summary>
public class F76A20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICCO.
        /// </summary>
        public const string ICCO = "ICCO";

        /// <summary>
        /// ICAEFC.
        /// </summary>
        public const string ICAEFC = "ICAEFC";

        /// <summary>
        /// ICARFC.
        /// </summary>
        public const string ICARFC = "ICARFC";

        /// <summary>
        /// ICPYIN.
        /// </summary>
        public const string ICPYIN = "ICPYIN";

        /// <summary>
        /// ICACIS.
        /// </summary>
        public const string ICACIS = "ICACIS";

        /// <summary>
        /// ICACI2.
        /// </summary>
        public const string ICACI2 = "ICACI2";

        /// <summary>
        /// ICADY.
        /// </summary>
        public const string ICADY = "ICADY";

        /// <summary>
        /// ICAA.
        /// </summary>
        public const string ICAA = "ICAA";

        /// <summary>
        /// ICACCN.
        /// </summary>
        public const string ICACCN = "ICACCN";

        /// <summary>
        /// ICDCT.
        /// </summary>
        public const string ICDCT = "ICDCT";

        /// <summary>
        /// ICAGRP.
        /// </summary>
        public const string ICAGRP = "ICAGRP";

        /// <summary>
        /// ICARBF.
        /// </summary>
        public const string ICARBF = "ICARBF";

        /// <summary>
        /// ICURAT.
        /// </summary>
        public const string ICURAT = "ICURAT";

        /// <summary>
        /// ICURC1.
        /// </summary>
        public const string ICURC1 = "ICURC1";

        /// <summary>
        /// ICURRF.
        /// </summary>
        public const string ICURRF = "ICURRF";

        /// <summary>
        /// ICURAB.
        /// </summary>
        public const string ICURAB = "ICURAB";

        /// <summary>
        /// ICURDT.
        /// </summary>
        public const string ICURDT = "ICURDT";

        /// <summary>
        /// ICTORG.
        /// </summary>
        public const string ICTORG = "ICTORG";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";

        /// <summary>
        /// ICCTID.
        /// </summary>
        public const string ICCTID = "ICCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F76A20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICCO", "ICCO", JdeDataType.String, 10, true, true),
        new JdeField("ICAEFC", "ICAEFC", JdeDataType.String, 2),
        new JdeField("ICARFC", "ICARFC", JdeDataType.String, 2),
        new JdeField("ICPYIN", "ICPYIN", JdeDataType.String, 2),
        new JdeField("ICACIS", "ICACIS", JdeDataType.String, 4),
        new JdeField("ICACI2", "ICACI2", JdeDataType.String, 4),
        new JdeField("ICADY", "ICADY", JdeDataType.Numeric),
        new JdeField("ICAA", "ICAA", JdeDataType.Numeric),
        new JdeField("ICACCN", "ICACCN", JdeDataType.Numeric),
        new JdeField("ICDCT", "ICDCT", JdeDataType.String, 4),
        new JdeField("ICAGRP", "ICAGRP", JdeDataType.String, 2),
        new JdeField("ICARBF", "ICARBF", JdeDataType.String, 2),
        new JdeField("ICURAT", "ICURAT", JdeDataType.Numeric),
        new JdeField("ICURC1", "ICURC1", JdeDataType.String, 6),
        new JdeField("ICURRF", "ICURRF", JdeDataType.String, 30),
        new JdeField("ICURAB", "ICURAB", JdeDataType.Numeric),
        new JdeField("ICURDT", "ICURDT", JdeDataType.Numeric),
        new JdeField("ICTORG", "ICTORG", JdeDataType.String, 20),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric),
        new JdeField("ICCTID", "ICCTID", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A20_0", "Primary Key on ICCO", new[] { "ICCO" }, isUnique: true, isPrimaryKey: true)
    };
}
