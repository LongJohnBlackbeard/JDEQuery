using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI006 - .
/// </summary>
public class F30UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILCTID.
        /// </summary>
        public const string ILCTID = "ILCTID";

        /// <summary>
        /// ILJOBS.
        /// </summary>
        public const string ILJOBS = "ILJOBS";

        /// <summary>
        /// ILLOTN.
        /// </summary>
        public const string ILLOTN = "ILLOTN";

        /// <summary>
        /// ILMCU.
        /// </summary>
        public const string ILMCU = "ILMCU";

        /// <summary>
        /// ILITM.
        /// </summary>
        public const string ILITM = "ILITM";

        /// <summary>
        /// ILCRDJ.
        /// </summary>
        public const string ILCRDJ = "ILCRDJ";

        /// <summary>
        /// ILTDAY.
        /// </summary>
        public const string ILTDAY = "ILTDAY";

        /// <summary>
        /// ILPLOT.
        /// </summary>
        public const string ILPLOT = "ILPLOT";

        /// <summary>
        /// ILMMCU.
        /// </summary>
        public const string ILMMCU = "ILMMCU";

        /// <summary>
        /// ILKIT.
        /// </summary>
        public const string ILKIT = "ILKIT";

        /// <summary>
        /// ILDOC.
        /// </summary>
        public const string ILDOC = "ILDOC";

        /// <summary>
        /// ILAN8.
        /// </summary>
        public const string ILAN8 = "ILAN8";

        /// <summary>
        /// ILTREF.
        /// </summary>
        public const string ILTREF = "ILTREF";

        /// <summary>
        /// ILTREX.
        /// </summary>
        public const string ILTREX = "ILTREX";

        /// <summary>
        /// ILDCT.
        /// </summary>
        public const string ILDCT = "ILDCT";

        /// <summary>
        /// ILRLLV.
        /// </summary>
        public const string ILRLLV = "ILRLLV";

        /// <summary>
        /// ILFRTO.
        /// </summary>
        public const string ILFRTO = "ILFRTO";

        /// <summary>
        /// ILTRQT.
        /// </summary>
        public const string ILTRQT = "ILTRQT";

        /// <summary>
        /// ILEV01.
        /// </summary>
        public const string ILEV01 = "ILEV01";

        /// <summary>
        /// ILEV02.
        /// </summary>
        public const string ILEV02 = "ILEV02";

        /// <summary>
        /// ILUKID.
        /// </summary>
        public const string ILUKID = "ILUKID";

        /// <summary>
        /// ILEV03.
        /// </summary>
        public const string ILEV03 = "ILEV03";

        /// <summary>
        /// ILEV04.
        /// </summary>
        public const string ILEV04 = "ILEV04";

        /// <summary>
        /// ILEV05.
        /// </summary>
        public const string ILEV05 = "ILEV05";

        /// <summary>
        /// ILLOCN.
        /// </summary>
        public const string ILLOCN = "ILLOCN";

        /// <summary>
        /// ILDOCO.
        /// </summary>
        public const string ILDOCO = "ILDOCO";

        /// <summary>
        /// ILEV06.
        /// </summary>
        public const string ILEV06 = "ILEV06";

        /// <summary>
        /// ILTRDJ.
        /// </summary>
        public const string ILTRDJ = "ILTRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILCTID", "ILCTID", JdeDataType.String, 30, true, true),
        new JdeField("ILJOBS", "ILJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ILLOTN", "ILLOTN", JdeDataType.String, 60),
        new JdeField("ILMCU", "ILMCU", JdeDataType.String, 24),
        new JdeField("ILITM", "ILITM", JdeDataType.Numeric),
        new JdeField("ILCRDJ", "ILCRDJ", JdeDataType.Numeric),
        new JdeField("ILTDAY", "ILTDAY", JdeDataType.Numeric),
        new JdeField("ILPLOT", "ILPLOT", JdeDataType.String, 60),
        new JdeField("ILMMCU", "ILMMCU", JdeDataType.String, 24),
        new JdeField("ILKIT", "ILKIT", JdeDataType.Numeric),
        new JdeField("ILDOC", "ILDOC", JdeDataType.Numeric),
        new JdeField("ILAN8", "ILAN8", JdeDataType.Numeric),
        new JdeField("ILTREF", "ILTREF", JdeDataType.String, 16),
        new JdeField("ILTREX", "ILTREX", JdeDataType.String, 60),
        new JdeField("ILDCT", "ILDCT", JdeDataType.String, 4),
        new JdeField("ILRLLV", "ILRLLV", JdeDataType.Numeric),
        new JdeField("ILFRTO", "ILFRTO", JdeDataType.String, 2),
        new JdeField("ILTRQT", "ILTRQT", JdeDataType.Numeric),
        new JdeField("ILEV01", "ILEV01", JdeDataType.String, 2),
        new JdeField("ILEV02", "ILEV02", JdeDataType.String, 2),
        new JdeField("ILUKID", "ILUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ILEV03", "ILEV03", JdeDataType.String, 2),
        new JdeField("ILEV04", "ILEV04", JdeDataType.String, 2),
        new JdeField("ILEV05", "ILEV05", JdeDataType.String, 2),
        new JdeField("ILLOCN", "ILLOCN", JdeDataType.String, 40),
        new JdeField("ILDOCO", "ILDOCO", JdeDataType.Numeric),
        new JdeField("ILEV06", "ILEV06", JdeDataType.String, 2),
        new JdeField("ILTRDJ", "ILTRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI006_0", "Primary Key on ILCTID, ILJOBS, ILUKID", new[] { "ILCTID", "ILJOBS", "ILUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI006_1", "Index on ILJOBS, ILCTID, ILRLLV, ILLOTN, ILMCU, ILITM, ILCRDJ, ILTDAY", new[] { "ILJOBS", "ILCTID", "ILRLLV", "ILLOTN", "ILMCU", "ILITM", "ILCRDJ", "ILTDAY" }),
        new JdeIndex("F30UI006_2", "Index on ILCTID, ILJOBS, ILRLLV, ILMMCU, ILKIT, ILCRDJ, ILTDAY", new[] { "ILCTID", "ILJOBS", "ILRLLV", "ILMMCU", "ILKIT", "ILCRDJ", "ILTDAY" }),
        new JdeIndex("F30UI006_4", "Index on ILCTID, ILJOBS, ILRLLV, ILDCT, ILLOTN, ILMCU, ILITM, ILPLOT, ILMMCU, ILKIT", new[] { "ILCTID", "ILJOBS", "ILRLLV", "ILDCT", "ILLOTN", "ILMCU", "ILITM", "ILPLOT", "ILMMCU", "ILKIT" }),
        new JdeIndex("F30UI006_5", "Index on ILCTID, ILJOBS, ILRLLV, ILDCT, ILLOTN, ILITM, ILMCU, ILDOC", new[] { "ILCTID", "ILJOBS", "ILRLLV", "ILDCT", "ILLOTN", "ILITM", "ILMCU", "ILDOC" }),
        new JdeIndex("F30UI006_6", "Index on ILCTID, ILJOBS, ILRLLV, ILDCT, ILLOTN, ILITM, ILMCU, ILLOCN, ILPLOT, ILKIT, ILMMCU", new[] { "ILCTID", "ILJOBS", "ILRLLV", "ILDCT", "ILLOTN", "ILITM", "ILMCU", "ILLOCN", "ILPLOT", "ILKIT", "ILMMCU" })
    };
}
