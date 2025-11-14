using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47003 - .
/// </summary>
public class F47003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SXCTID.
        /// </summary>
        public const string SXCTID = "SXCTID";

        /// <summary>
        /// SXJOBS.
        /// </summary>
        public const string SXJOBS = "SXJOBS";

        /// <summary>
        /// SXFILE.
        /// </summary>
        public const string SXFILE = "SXFILE";

        /// <summary>
        /// SXEDOC.
        /// </summary>
        public const string SXEDOC = "SXEDOC";

        /// <summary>
        /// SXEDCT.
        /// </summary>
        public const string SXEDCT = "SXEDCT";

        /// <summary>
        /// SXEKCO.
        /// </summary>
        public const string SXEKCO = "SXEKCO";

        /// <summary>
        /// SXEDLN.
        /// </summary>
        public const string SXEDLN = "SXEDLN";

        /// <summary>
        /// SXEDBT.
        /// </summary>
        public const string SXEDBT = "SXEDBT";

        /// <summary>
        /// SXEDST.
        /// </summary>
        public const string SXEDST = "SXEDST";

        /// <summary>
        /// SXDOCO.
        /// </summary>
        public const string SXDOCO = "SXDOCO";

        /// <summary>
        /// SXDCTO.
        /// </summary>
        public const string SXDCTO = "SXDCTO";

        /// <summary>
        /// SXKCOO.
        /// </summary>
        public const string SXKCOO = "SXKCOO";

        /// <summary>
        /// SXLNID.
        /// </summary>
        public const string SXLNID = "SXLNID";

        /// <summary>
        /// SXDTAI.
        /// </summary>
        public const string SXDTAI = "SXDTAI";

        /// <summary>
        /// SXDSCA.
        /// </summary>
        public const string SXDSCA = "SXDSCA";

        /// <summary>
        /// SXCRVL.
        /// </summary>
        public const string SXCRVL = "SXCRVL";

        /// <summary>
        /// SXCGVL.
        /// </summary>
        public const string SXCGVL = "SXCGVL";

        /// <summary>
        /// SXEDTY.
        /// </summary>
        public const string SXEDTY = "SXEDTY";
    }

    /// <inheritdoc />
    public override string TableName => "F47003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SXCTID", "SXCTID", JdeDataType.String, 30, true, true),
        new JdeField("SXJOBS", "SXJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SXFILE", "SXFILE", JdeDataType.String, 20, true, true),
        new JdeField("SXEDOC", "SXEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SXEDCT", "SXEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SXEKCO", "SXEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SXEDLN", "SXEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SXEDBT", "SXEDBT", JdeDataType.String, 30),
        new JdeField("SXEDST", "SXEDST", JdeDataType.String, 12),
        new JdeField("SXDOCO", "SXDOCO", JdeDataType.Numeric),
        new JdeField("SXDCTO", "SXDCTO", JdeDataType.String, 4),
        new JdeField("SXKCOO", "SXKCOO", JdeDataType.String, 10),
        new JdeField("SXLNID", "SXLNID", JdeDataType.Numeric),
        new JdeField("SXDTAI", "SXDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SXDSCA", "SXDSCA", JdeDataType.String, 80),
        new JdeField("SXCRVL", "SXCRVL", JdeDataType.String, 80),
        new JdeField("SXCGVL", "SXCGVL", JdeDataType.String, 80),
        new JdeField("SXEDTY", "SXEDTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47003_0", "Primary Key on SXCTID, SXJOBS, SXFILE, SXEDOC, SXEDCT, SXEKCO, SXEDLN, SXDTAI", new[] { "SXCTID", "SXJOBS", "SXFILE", "SXEDOC", "SXEDCT", "SXEKCO", "SXEDLN", "SXDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
