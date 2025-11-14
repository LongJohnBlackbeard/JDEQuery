using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08371 - .
/// </summary>
public class F08371 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B6AN8.
        /// </summary>
        public const string B6AN8 = "B6AN8";

        /// <summary>
        /// B6RSAY.
        /// </summary>
        public const string B6RSAY = "B6RSAY";

        /// <summary>
        /// B6PLAN.
        /// </summary>
        public const string B6PLAN = "B6PLAN";

        /// <summary>
        /// B6SPC.
        /// </summary>
        public const string B6SPC = "B6SPC";

        /// <summary>
        /// B6SVD.
        /// </summary>
        public const string B6SVD = "B6SVD";

        /// <summary>
        /// B6EED.
        /// </summary>
        public const string B6EED = "B6EED";

        /// <summary>
        /// B6SVDB.
        /// </summary>
        public const string B6SVDB = "B6SVDB";

        /// <summary>
        /// B6SVDE.
        /// </summary>
        public const string B6SVDE = "B6SVDE";

        /// <summary>
        /// B6PCNO.
        /// </summary>
        public const string B6PCNO = "B6PCNO";

        /// <summary>
        /// B6ANN8.
        /// </summary>
        public const string B6ANN8 = "B6ANN8";

        /// <summary>
        /// B6PAN8.
        /// </summary>
        public const string B6PAN8 = "B6PAN8";

        /// <summary>
        /// B6SACD.
        /// </summary>
        public const string B6SACD = "B6SACD";

        /// <summary>
        /// B6EX.
        /// </summary>
        public const string B6EX = "B6EX";

        /// <summary>
        /// B6SACC.
        /// </summary>
        public const string B6SACC = "B6SACC";

        /// <summary>
        /// B6PDBA.
        /// </summary>
        public const string B6PDBA = "B6PDBA";

        /// <summary>
        /// B6CKCS.
        /// </summary>
        public const string B6CKCS = "B6CKCS";

        /// <summary>
        /// B6CKCR.
        /// </summary>
        public const string B6CKCR = "B6CKCR";

        /// <summary>
        /// B6CKCN.
        /// </summary>
        public const string B6CKCN = "B6CKCN";

        /// <summary>
        /// B6CKDT.
        /// </summary>
        public const string B6CKDT = "B6CKDT";

        /// <summary>
        /// B6DOCM.
        /// </summary>
        public const string B6DOCM = "B6DOCM";

        /// <summary>
        /// B6YTDC.
        /// </summary>
        public const string B6YTDC = "B6YTDC";

        /// <summary>
        /// B6YTDR.
        /// </summary>
        public const string B6YTDR = "B6YTDR";

        /// <summary>
        /// B6SADC.
        /// </summary>
        public const string B6SADC = "B6SADC";

        /// <summary>
        /// B6YTDB.
        /// </summary>
        public const string B6YTDB = "B6YTDB";

        /// <summary>
        /// B6YTDO.
        /// </summary>
        public const string B6YTDO = "B6YTDO";

        /// <summary>
        /// B6YTDM.
        /// </summary>
        public const string B6YTDM = "B6YTDM";

        /// <summary>
        /// B6IST.
        /// </summary>
        public const string B6IST = "B6IST";

        /// <summary>
        /// B6ICC.
        /// </summary>
        public const string B6ICC = "B6ICC";

        /// <summary>
        /// B6PRTR.
        /// </summary>
        public const string B6PRTR = "B6PRTR";

        /// <summary>
        /// B6DICJ.
        /// </summary>
        public const string B6DICJ = "B6DICJ";

        /// <summary>
        /// B6SINT.
        /// </summary>
        public const string B6SINT = "B6SINT";

        /// <summary>
        /// B6ICU.
        /// </summary>
        public const string B6ICU = "B6ICU";

        /// <summary>
        /// B6USER.
        /// </summary>
        public const string B6USER = "B6USER";

        /// <summary>
        /// B6PID.
        /// </summary>
        public const string B6PID = "B6PID";

        /// <summary>
        /// B6JOBN.
        /// </summary>
        public const string B6JOBN = "B6JOBN";

        /// <summary>
        /// B6UPMJ.
        /// </summary>
        public const string B6UPMJ = "B6UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08371";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B6AN8", "B6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("B6RSAY", "B6RSAY", JdeDataType.Numeric, null, true, true),
        new JdeField("B6PLAN", "B6PLAN", JdeDataType.String, 16, true, true),
        new JdeField("B6SPC", "B6SPC", JdeDataType.String, 4),
        new JdeField("B6SVD", "B6SVD", JdeDataType.Numeric, null, true, true),
        new JdeField("B6EED", "B6EED", JdeDataType.Numeric),
        new JdeField("B6SVDB", "B6SVDB", JdeDataType.Numeric),
        new JdeField("B6SVDE", "B6SVDE", JdeDataType.Numeric),
        new JdeField("B6PCNO", "B6PCNO", JdeDataType.Numeric, null, true, true),
        new JdeField("B6ANN8", "B6ANN8", JdeDataType.Numeric),
        new JdeField("B6PAN8", "B6PAN8", JdeDataType.Numeric),
        new JdeField("B6SACD", "B6SACD", JdeDataType.String, 4),
        new JdeField("B6EX", "B6EX", JdeDataType.String, 60),
        new JdeField("B6SACC", "B6SACC", JdeDataType.String, 6),
        new JdeField("B6PDBA", "B6PDBA", JdeDataType.Numeric),
        new JdeField("B6CKCS", "B6CKCS", JdeDataType.String, 30, true, true),
        new JdeField("B6CKCR", "B6CKCR", JdeDataType.String, 30),
        new JdeField("B6CKCN", "B6CKCN", JdeDataType.Numeric),
        new JdeField("B6CKDT", "B6CKDT", JdeDataType.Numeric),
        new JdeField("B6DOCM", "B6DOCM", JdeDataType.Numeric),
        new JdeField("B6YTDC", "B6YTDC", JdeDataType.Numeric),
        new JdeField("B6YTDR", "B6YTDR", JdeDataType.Numeric),
        new JdeField("B6SADC", "B6SADC", JdeDataType.Numeric),
        new JdeField("B6YTDB", "B6YTDB", JdeDataType.Numeric),
        new JdeField("B6YTDO", "B6YTDO", JdeDataType.Numeric),
        new JdeField("B6YTDM", "B6YTDM", JdeDataType.Numeric),
        new JdeField("B6IST", "B6IST", JdeDataType.String, 2),
        new JdeField("B6ICC", "B6ICC", JdeDataType.String, 2),
        new JdeField("B6PRTR", "B6PRTR", JdeDataType.Numeric),
        new JdeField("B6DICJ", "B6DICJ", JdeDataType.Numeric),
        new JdeField("B6SINT", "B6SINT", JdeDataType.String, 20),
        new JdeField("B6ICU", "B6ICU", JdeDataType.Numeric),
        new JdeField("B6USER", "B6USER", JdeDataType.String, 20),
        new JdeField("B6PID", "B6PID", JdeDataType.String, 20),
        new JdeField("B6JOBN", "B6JOBN", JdeDataType.String, 20),
        new JdeField("B6UPMJ", "B6UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08371_0", "Primary Key on B6RSAY, B6AN8, B6PLAN, B6SVD, B6CKCS, B6PCNO", new[] { "B6RSAY", "B6AN8", "B6PLAN", "B6SVD", "B6CKCS", "B6PCNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08371_2", "Index on B6EED, B6ICU, B6AN8, B6SVD, B6PRTR", new[] { "B6EED", "B6ICU", "B6AN8", "B6SVD", "B6PRTR" }),
        new JdeIndex("F08371_3", "Index on B6AN8, B6PRTR", new[] { "B6AN8", "B6PRTR" }),
        new JdeIndex("F08371_4", "Index on B6RSAY, B6AN8, B6PLAN, B6CKDT, B6DOCM", new[] { "B6RSAY", "B6AN8", "B6PLAN", "B6CKDT", "B6DOCM" }),
        new JdeIndex("F08371_5", "Index on B6PLAN, B6CKCS", new[] { "B6PLAN", "B6CKCS" }),
        new JdeIndex("F08371_6", "Index on B6AN8, B6CKCS, B6PCNO", new[] { "B6AN8", "B6CKCS", "B6PCNO" }),
        new JdeIndex("F08371_8", "Index on B6RSAY, B6SACD, B6PLAN, B6AN8", new[] { "B6RSAY", "B6SACD", "B6PLAN", "B6AN8" })
    };
}
