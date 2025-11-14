using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43213 - .
/// </summary>
public class F43213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPPSVE.
        /// </summary>
        public const string VPPSVE = "VPPSVE";

        /// <summary>
        /// VPDOCO.
        /// </summary>
        public const string VPDOCO = "VPDOCO";

        /// <summary>
        /// VPDCTO.
        /// </summary>
        public const string VPDCTO = "VPDCTO";

        /// <summary>
        /// VPLNID.
        /// </summary>
        public const string VPLNID = "VPLNID";

        /// <summary>
        /// VPDTE.
        /// </summary>
        public const string VPDTE = "VPDTE";

        /// <summary>
        /// VPMMCU.
        /// </summary>
        public const string VPMMCU = "VPMMCU";

        /// <summary>
        /// VPAN8.
        /// </summary>
        public const string VPAN8 = "VPAN8";

        /// <summary>
        /// VPITM.
        /// </summary>
        public const string VPITM = "VPITM";

        /// <summary>
        /// VPLITM.
        /// </summary>
        public const string VPLITM = "VPLITM";

        /// <summary>
        /// VPAITM.
        /// </summary>
        public const string VPAITM = "VPAITM";

        /// <summary>
        /// VPMXQT.
        /// </summary>
        public const string VPMXQT = "VPMXQT";

        /// <summary>
        /// VPDLTM.
        /// </summary>
        public const string VPDLTM = "VPDLTM";

        /// <summary>
        /// VPVLOT.
        /// </summary>
        public const string VPVLOT = "VPVLOT";

        /// <summary>
        /// VPPATN.
        /// </summary>
        public const string VPPATN = "VPPATN";

        /// <summary>
        /// VPMWDH.
        /// </summary>
        public const string VPMWDH = "VPMWDH";

        /// <summary>
        /// VPLOCN.
        /// </summary>
        public const string VPLOCN = "VPLOCN";

        /// <summary>
        /// VPURAT.
        /// </summary>
        public const string VPURAT = "VPURAT";

        /// <summary>
        /// VPURCD.
        /// </summary>
        public const string VPURCD = "VPURCD";

        /// <summary>
        /// VPURDT.
        /// </summary>
        public const string VPURDT = "VPURDT";

        /// <summary>
        /// VPURAB.
        /// </summary>
        public const string VPURAB = "VPURAB";

        /// <summary>
        /// VPURRF.
        /// </summary>
        public const string VPURRF = "VPURRF";

        /// <summary>
        /// VPUSER.
        /// </summary>
        public const string VPUSER = "VPUSER";

        /// <summary>
        /// VPPID.
        /// </summary>
        public const string VPPID = "VPPID";

        /// <summary>
        /// VPJOBN.
        /// </summary>
        public const string VPJOBN = "VPJOBN";

        /// <summary>
        /// VPUPMJ.
        /// </summary>
        public const string VPUPMJ = "VPUPMJ";

        /// <summary>
        /// VPTDAY.
        /// </summary>
        public const string VPTDAY = "VPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPPSVE", "VPPSVE", JdeDataType.String, 6, true, true),
        new JdeField("VPDOCO", "VPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("VPDCTO", "VPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("VPLNID", "VPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VPDTE", "VPDTE", JdeDataType.Numeric, null, true, true),
        new JdeField("VPMMCU", "VPMMCU", JdeDataType.String, 24, true, true),
        new JdeField("VPAN8", "VPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VPITM", "VPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("VPLITM", "VPLITM", JdeDataType.String, 50),
        new JdeField("VPAITM", "VPAITM", JdeDataType.String, 50),
        new JdeField("VPMXQT", "VPMXQT", JdeDataType.Numeric),
        new JdeField("VPDLTM", "VPDLTM", JdeDataType.Numeric),
        new JdeField("VPVLOT", "VPVLOT", JdeDataType.Numeric),
        new JdeField("VPPATN", "VPPATN", JdeDataType.Numeric),
        new JdeField("VPMWDH", "VPMWDH", JdeDataType.String, 2),
        new JdeField("VPLOCN", "VPLOCN", JdeDataType.String, 40),
        new JdeField("VPURAT", "VPURAT", JdeDataType.Numeric),
        new JdeField("VPURCD", "VPURCD", JdeDataType.String, 4),
        new JdeField("VPURDT", "VPURDT", JdeDataType.Numeric),
        new JdeField("VPURAB", "VPURAB", JdeDataType.Numeric),
        new JdeField("VPURRF", "VPURRF", JdeDataType.String, 30),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPJOBN", "VPJOBN", JdeDataType.String, 20),
        new JdeField("VPUPMJ", "VPUPMJ", JdeDataType.Numeric),
        new JdeField("VPTDAY", "VPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43213_0", "Primary Key on VPPSVE, VPMMCU, VPAN8, VPITM, VPDOCO, VPDCTO, VPLNID, VPDTE", new[] { "VPPSVE", "VPMMCU", "VPAN8", "VPITM", "VPDOCO", "VPDCTO", "VPLNID", "VPDTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43213_2", "Index on VPPSVE, VPMMCU, VPAN8, VPITM, VPDOCO, VPDCTO, VPLNID, SYS_NC00027$", new[] { "VPPSVE", "VPMMCU", "VPAN8", "VPITM", "VPDOCO", "VPDCTO", "VPLNID", "SYS_NC00027$" })
    };
}
