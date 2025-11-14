using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08392 - .
/// </summary>
public class F08392 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BFPLAN.
        /// </summary>
        public const string BFPLAN = "BFPLAN";

        /// <summary>
        /// BFE010.
        /// </summary>
        public const string BFE010 = "BFE010";

        /// <summary>
        /// BFXDFS.
        /// </summary>
        public const string BFXDFS = "BFXDFS";

        /// <summary>
        /// BFPLNF.
        /// </summary>
        public const string BFPLNF = "BFPLNF";

        /// <summary>
        /// BFENRP.
        /// </summary>
        public const string BFENRP = "BFENRP";

        /// <summary>
        /// BFECHK.
        /// </summary>
        public const string BFECHK = "BFECHK";

        /// <summary>
        /// BFTMCD.
        /// </summary>
        public const string BFTMCD = "BFTMCD";

        /// <summary>
        /// BFXEST.
        /// </summary>
        public const string BFXEST = "BFXEST";

        /// <summary>
        /// BFMCHK.
        /// </summary>
        public const string BFMCHK = "BFMCHK";

        /// <summary>
        /// BFENR2.
        /// </summary>
        public const string BFENR2 = "BFENR2";

        /// <summary>
        /// BFECK2.
        /// </summary>
        public const string BFECK2 = "BFECK2";

        /// <summary>
        /// BFTCD2.
        /// </summary>
        public const string BFTCD2 = "BFTCD2";

        /// <summary>
        /// BFXST2.
        /// </summary>
        public const string BFXST2 = "BFXST2";

        /// <summary>
        /// BFMCK2.
        /// </summary>
        public const string BFMCK2 = "BFMCK2";
    }

    /// <inheritdoc />
    public override string TableName => "F08392";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BFPLAN", "BFPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BFE010", "BFE010", JdeDataType.String, 2, true, true),
        new JdeField("BFXDFS", "BFXDFS", JdeDataType.String, 6, true, true),
        new JdeField("BFPLNF", "BFPLNF", JdeDataType.String, 2, true, true),
        new JdeField("BFENRP", "BFENRP", JdeDataType.String, 2),
        new JdeField("BFECHK", "BFECHK", JdeDataType.String, 2),
        new JdeField("BFTMCD", "BFTMCD", JdeDataType.String, 4),
        new JdeField("BFXEST", "BFXEST", JdeDataType.String, 6),
        new JdeField("BFMCHK", "BFMCHK", JdeDataType.String, 2),
        new JdeField("BFENR2", "BFENR2", JdeDataType.String, 2),
        new JdeField("BFECK2", "BFECK2", JdeDataType.String, 2),
        new JdeField("BFTCD2", "BFTCD2", JdeDataType.String, 4),
        new JdeField("BFXST2", "BFXST2", JdeDataType.String, 6),
        new JdeField("BFMCK2", "BFMCK2", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08392_0", "Primary Key on BFPLAN, BFE010, BFXDFS, BFPLNF", new[] { "BFPLAN", "BFE010", "BFXDFS", "BFPLNF" }, isUnique: true, isPrimaryKey: true)
    };
}
