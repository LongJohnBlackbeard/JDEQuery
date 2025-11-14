using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085550 - .
/// </summary>
public class F085550 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IOEECD.
        /// </summary>
        public const string IOEECD = "IOEECD";

        /// <summary>
        /// IOPIDI.
        /// </summary>
        public const string IOPIDI = "IOPIDI";

        /// <summary>
        /// IOCCPR.
        /// </summary>
        public const string IOCCPR = "IOCCPR";

        /// <summary>
        /// IOCO.
        /// </summary>
        public const string IOCO = "IOCO";

        /// <summary>
        /// IOVERS.
        /// </summary>
        public const string IOVERS = "IOVERS";

        /// <summary>
        /// IODDGRP.
        /// </summary>
        public const string IODDGRP = "IODDGRP";

        /// <summary>
        /// IOAUPD.
        /// </summary>
        public const string IOAUPD = "IOAUPD";

        /// <summary>
        /// IODSPA1.
        /// </summary>
        public const string IODSPA1 = "IODSPA1";

        /// <summary>
        /// IOUSER.
        /// </summary>
        public const string IOUSER = "IOUSER";

        /// <summary>
        /// IOPID.
        /// </summary>
        public const string IOPID = "IOPID";

        /// <summary>
        /// IOJOBN.
        /// </summary>
        public const string IOJOBN = "IOJOBN";

        /// <summary>
        /// IOUPMJ.
        /// </summary>
        public const string IOUPMJ = "IOUPMJ";

        /// <summary>
        /// IOUPMT.
        /// </summary>
        public const string IOUPMT = "IOUPMT";

        /// <summary>
        /// IOAN8.
        /// </summary>
        public const string IOAN8 = "IOAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F085550";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IOEECD", "IOEECD", JdeDataType.String, 6, true, true),
        new JdeField("IOPIDI", "IOPIDI", JdeDataType.String, 20, true, true),
        new JdeField("IOCCPR", "IOCCPR", JdeDataType.String, 6, true, true),
        new JdeField("IOCO", "IOCO", JdeDataType.String, 10, true, true),
        new JdeField("IOVERS", "IOVERS", JdeDataType.String, 20, true, true),
        new JdeField("IODDGRP", "IODDGRP", JdeDataType.String, 6, true, true),
        new JdeField("IOAUPD", "IOAUPD", JdeDataType.String, 2),
        new JdeField("IODSPA1", "IODSPA1", JdeDataType.String, 2),
        new JdeField("IOUSER", "IOUSER", JdeDataType.String, 20),
        new JdeField("IOPID", "IOPID", JdeDataType.String, 20),
        new JdeField("IOJOBN", "IOJOBN", JdeDataType.String, 20),
        new JdeField("IOUPMJ", "IOUPMJ", JdeDataType.Numeric),
        new JdeField("IOUPMT", "IOUPMT", JdeDataType.Numeric),
        new JdeField("IOAN8", "IOAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085550_0", "Primary Key on IOEECD, IOCO, IODDGRP, IOVERS, IOCCPR, IOPIDI", new[] { "IOEECD", "IOCO", "IODDGRP", "IOVERS", "IOCCPR", "IOPIDI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085550_2", "Index on IOCO, IODDGRP, IOPIDI, IOEECD", new[] { "IOCO", "IODDGRP", "IOPIDI", "IOEECD" })
    };
}
