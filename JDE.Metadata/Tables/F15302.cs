using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15302 - .
/// </summary>
public class F15302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTLTGRP.
        /// </summary>
        public const string LTLTGRP = "LTLTGRP";

        /// <summary>
        /// LTEPGENT.
        /// </summary>
        public const string LTEPGENT = "LTEPGENT";

        /// <summary>
        /// LTLT.
        /// </summary>
        public const string LTLT = "LTLT";

        /// <summary>
        /// LTDL01.
        /// </summary>
        public const string LTDL01 = "LTDL01";

        /// <summary>
        /// LTURCD.
        /// </summary>
        public const string LTURCD = "LTURCD";

        /// <summary>
        /// LTURDT.
        /// </summary>
        public const string LTURDT = "LTURDT";

        /// <summary>
        /// LTURAT.
        /// </summary>
        public const string LTURAT = "LTURAT";

        /// <summary>
        /// LTURAB.
        /// </summary>
        public const string LTURAB = "LTURAB";

        /// <summary>
        /// LTURRF.
        /// </summary>
        public const string LTURRF = "LTURRF";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTMKEY.
        /// </summary>
        public const string LTMKEY = "LTMKEY";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTUPMT.
        /// </summary>
        public const string LTUPMT = "LTUPMT";

        /// <summary>
        /// LTTORG.
        /// </summary>
        public const string LTTORG = "LTTORG";

        /// <summary>
        /// LTENTJ.
        /// </summary>
        public const string LTENTJ = "LTENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTLTGRP", "LTLTGRP", JdeDataType.String, 30, true, true),
        new JdeField("LTEPGENT", "LTEPGENT", JdeDataType.String, 2, true, true),
        new JdeField("LTLT", "LTLT", JdeDataType.String, 4, true, true),
        new JdeField("LTDL01", "LTDL01", JdeDataType.String, 60),
        new JdeField("LTURCD", "LTURCD", JdeDataType.String, 4),
        new JdeField("LTURDT", "LTURDT", JdeDataType.Numeric),
        new JdeField("LTURAT", "LTURAT", JdeDataType.Numeric),
        new JdeField("LTURAB", "LTURAB", JdeDataType.Numeric),
        new JdeField("LTURRF", "LTURRF", JdeDataType.String, 30),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTMKEY", "LTMKEY", JdeDataType.String, 30),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTUPMT", "LTUPMT", JdeDataType.Numeric),
        new JdeField("LTTORG", "LTTORG", JdeDataType.String, 20),
        new JdeField("LTENTJ", "LTENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15302_0", "Primary Key on LTLTGRP, LTEPGENT, LTLT", new[] { "LTLTGRP", "LTEPGENT", "LTLT" }, isUnique: true, isPrimaryKey: true)
    };
}
