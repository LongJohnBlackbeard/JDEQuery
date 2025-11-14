using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7608B - .
/// </summary>
public class F7608B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TBSHST.
        /// </summary>
        public const string TBSHST = "TBSHST";

        /// <summary>
        /// TBADDS.
        /// </summary>
        public const string TBADDS = "TBADDS";

        /// <summary>
        /// TBITM.
        /// </summary>
        public const string TBITM = "TBITM";

        /// <summary>
        /// TBTXR1.
        /// </summary>
        public const string TBTXR1 = "TBTXR1";

        /// <summary>
        /// TBTXR2.
        /// </summary>
        public const string TBTXR2 = "TBTXR2";

        /// <summary>
        /// TBBISF.
        /// </summary>
        public const string TBBISF = "TBBISF";

        /// <summary>
        /// TBBISR.
        /// </summary>
        public const string TBBISR = "TBBISR";

        /// <summary>
        /// TBBIRF.
        /// </summary>
        public const string TBBIRF = "TBBIRF";

        /// <summary>
        /// TBTA1.
        /// </summary>
        public const string TBTA1 = "TBTA1";

        /// <summary>
        /// TBGL01.
        /// </summary>
        public const string TBGL01 = "TBGL01";

        /// <summary>
        /// TBTORG.
        /// </summary>
        public const string TBTORG = "TBTORG";

        /// <summary>
        /// TBAC76.
        /// </summary>
        public const string TBAC76 = "TBAC76";

        /// <summary>
        /// TBUSER.
        /// </summary>
        public const string TBUSER = "TBUSER";

        /// <summary>
        /// TBPID.
        /// </summary>
        public const string TBPID = "TBPID";

        /// <summary>
        /// TBJOBN.
        /// </summary>
        public const string TBJOBN = "TBJOBN";

        /// <summary>
        /// TBUPMJ.
        /// </summary>
        public const string TBUPMJ = "TBUPMJ";

        /// <summary>
        /// TBTDAY.
        /// </summary>
        public const string TBTDAY = "TBTDAY";

        /// <summary>
        /// TBBORI.
        /// </summary>
        public const string TBBORI = "TBBORI";

        /// <summary>
        /// TBB76DFPR.
        /// </summary>
        public const string TBB76DFPR = "TBB76DFPR";

        /// <summary>
        /// TBB76CFFR.
        /// </summary>
        public const string TBB76CFFR = "TBB76CFFR";

        /// <summary>
        /// TBB76CTTO.
        /// </summary>
        public const string TBB76CTTO = "TBB76CTTO";

        /// <summary>
        /// TBPVAD.
        /// </summary>
        public const string TBPVAD = "TBPVAD";

        /// <summary>
        /// TBPVRATE.
        /// </summary>
        public const string TBPVRATE = "TBPVRATE";
    }

    /// <inheritdoc />
    public override string TableName => "F7608B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TBSHST", "TBSHST", JdeDataType.String, 6, true, true),
        new JdeField("TBADDS", "TBADDS", JdeDataType.String, 6, true, true),
        new JdeField("TBITM", "TBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TBTXR1", "TBTXR1", JdeDataType.Numeric),
        new JdeField("TBTXR2", "TBTXR2", JdeDataType.Numeric),
        new JdeField("TBBISF", "TBBISF", JdeDataType.Numeric),
        new JdeField("TBBISR", "TBBISR", JdeDataType.Numeric),
        new JdeField("TBBIRF", "TBBIRF", JdeDataType.Numeric),
        new JdeField("TBTA1", "TBTA1", JdeDataType.Numeric),
        new JdeField("TBGL01", "TBGL01", JdeDataType.String, 8),
        new JdeField("TBTORG", "TBTORG", JdeDataType.String, 20),
        new JdeField("TBAC76", "TBAC76", JdeDataType.String, 6, true, true),
        new JdeField("TBUSER", "TBUSER", JdeDataType.String, 20),
        new JdeField("TBPID", "TBPID", JdeDataType.String, 20),
        new JdeField("TBJOBN", "TBJOBN", JdeDataType.String, 20),
        new JdeField("TBUPMJ", "TBUPMJ", JdeDataType.Numeric),
        new JdeField("TBTDAY", "TBTDAY", JdeDataType.Numeric),
        new JdeField("TBBORI", "TBBORI", JdeDataType.String, 2, true, true),
        new JdeField("TBB76DFPR", "TBB76DFPR", JdeDataType.Numeric),
        new JdeField("TBB76CFFR", "TBB76CFFR", JdeDataType.Numeric),
        new JdeField("TBB76CTTO", "TBB76CTTO", JdeDataType.Numeric),
        new JdeField("TBPVAD", "TBPVAD", JdeDataType.String, 2),
        new JdeField("TBPVRATE", "TBPVRATE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7608B_0", "Primary Key on TBADDS, TBSHST, TBITM, TBAC76, TBBORI", new[] { "TBADDS", "TBSHST", "TBITM", "TBAC76", "TBBORI" }, isUnique: true, isPrimaryKey: true)
    };
}
