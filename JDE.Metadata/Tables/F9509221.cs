using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9509221 - .
/// </summary>
public class F9509221 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTDATS.
        /// </summary>
        public const string OTDATS = "OTDATS";

        /// <summary>
        /// OTOBNM.
        /// </summary>
        public const string OTOBNM = "OTOBNM";

        /// <summary>
        /// OTFMNM.
        /// </summary>
        public const string OTFMNM = "OTFMNM";

        /// <summary>
        /// OTGNCID2.
        /// </summary>
        public const string OTGNCID2 = "OTGNCID2";

        /// <summary>
        /// OTRCRDTP.
        /// </summary>
        public const string OTRCRDTP = "OTRCRDTP";

        /// <summary>
        /// OTWEVENT.
        /// </summary>
        public const string OTWEVENT = "OTWEVENT";

        /// <summary>
        /// OTCTRLID.
        /// </summary>
        public const string OTCTRLID = "OTCTRLID";

        /// <summary>
        /// OTCTYPE.
        /// </summary>
        public const string OTCTYPE = "OTCTYPE";

        /// <summary>
        /// OTGNCID4.
        /// </summary>
        public const string OTGNCID4 = "OTGNCID4";

        /// <summary>
        /// OTMRGMOD.
        /// </summary>
        public const string OTMRGMOD = "OTMRGMOD";

        /// <summary>
        /// OTTEXTID1.
        /// </summary>
        public const string OTTEXTID1 = "OTTEXTID1";

        /// <summary>
        /// OTTEXTID2.
        /// </summary>
        public const string OTTEXTID2 = "OTTEXTID2";

        /// <summary>
        /// OTTEXTID3.
        /// </summary>
        public const string OTTEXTID3 = "OTTEXTID3";

        /// <summary>
        /// OTTEXTID4.
        /// </summary>
        public const string OTTEXTID4 = "OTTEXTID4";

        /// <summary>
        /// OTTEXTID5.
        /// </summary>
        public const string OTTEXTID5 = "OTTEXTID5";

        /// <summary>
        /// OTTEXTID6.
        /// </summary>
        public const string OTTEXTID6 = "OTTEXTID6";

        /// <summary>
        /// OTOVFG.
        /// </summary>
        public const string OTOVFG = "OTOVFG";

        /// <summary>
        /// OTTEXTVIS.
        /// </summary>
        public const string OTTEXTVIS = "OTTEXTVIS";

        /// <summary>
        /// OTTEXTID7.
        /// </summary>
        public const string OTTEXTID7 = "OTTEXTID7";

        /// <summary>
        /// OTTEXTID8.
        /// </summary>
        public const string OTTEXTID8 = "OTTEXTID8";

        /// <summary>
        /// OTTEXTID9.
        /// </summary>
        public const string OTTEXTID9 = "OTTEXTID9";

        /// <summary>
        /// OTTEXTID10.
        /// </summary>
        public const string OTTEXTID10 = "OTTEXTID10";
    }

    /// <inheritdoc />
    public override string TableName => "F9509221";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTDATS", "OTDATS", JdeDataType.String, 60, true, true),
        new JdeField("OTOBNM", "OTOBNM", JdeDataType.String, 20, true, true),
        new JdeField("OTFMNM", "OTFMNM", JdeDataType.String, 20, true, true),
        new JdeField("OTGNCID2", "OTGNCID2", JdeDataType.Numeric, null, true, true),
        new JdeField("OTRCRDTP", "OTRCRDTP", JdeDataType.Numeric, null, true, true),
        new JdeField("OTWEVENT", "OTWEVENT", JdeDataType.Numeric, null, true, true),
        new JdeField("OTCTRLID", "OTCTRLID", JdeDataType.Numeric),
        new JdeField("OTCTYPE", "OTCTYPE", JdeDataType.Numeric),
        new JdeField("OTGNCID4", "OTGNCID4", JdeDataType.Numeric, null, true, true),
        new JdeField("OTMRGMOD", "OTMRGMOD", JdeDataType.String, 2),
        new JdeField("OTTEXTID1", "OTTEXTID1", JdeDataType.Numeric, null, true, true),
        new JdeField("OTTEXTID2", "OTTEXTID2", JdeDataType.Numeric, null, true, true),
        new JdeField("OTTEXTID3", "OTTEXTID3", JdeDataType.Numeric, null, true, true),
        new JdeField("OTTEXTID4", "OTTEXTID4", JdeDataType.Numeric),
        new JdeField("OTTEXTID5", "OTTEXTID5", JdeDataType.Numeric),
        new JdeField("OTTEXTID6", "OTTEXTID6", JdeDataType.Numeric),
        new JdeField("OTOVFG", "OTOVFG", JdeDataType.String, 2),
        new JdeField("OTTEXTVIS", "OTTEXTVIS", JdeDataType.String, 2),
        new JdeField("OTTEXTID7", "OTTEXTID7", JdeDataType.Numeric),
        new JdeField("OTTEXTID8", "OTTEXTID8", JdeDataType.Numeric),
        new JdeField("OTTEXTID9", "OTTEXTID9", JdeDataType.Numeric),
        new JdeField("OTTEXTID10", "OTTEXTID10", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9509221_0", "Primary Key on OTDATS, OTOBNM, OTFMNM, OTGNCID4, OTGNCID2, OTRCRDTP, OTWEVENT, OTTEXTID1, OTTEXTID2, OTTEXTID3", new[] { "OTDATS", "OTOBNM", "OTFMNM", "OTGNCID4", "OTGNCID2", "OTRCRDTP", "OTWEVENT", "OTTEXTID1", "OTTEXTID2", "OTTEXTID3" }, isUnique: true, isPrimaryKey: true)
    };
}
