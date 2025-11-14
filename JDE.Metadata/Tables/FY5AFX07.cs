using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX07 - .
/// </summary>
public class FY5AFX07 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIY5AFTMPL.
        /// </summary>
        public const string DIY5AFTMPL = "DIY5AFTMPL";

        /// <summary>
        /// DISETY.
        /// </summary>
        public const string DISETY = "DISETY";

        /// <summary>
        /// DIY5AFCPID.
        /// </summary>
        public const string DIY5AFCPID = "DIY5AFCPID";

        /// <summary>
        /// DIOBNM.
        /// </summary>
        public const string DIOBNM = "DIOBNM";

        /// <summary>
        /// DIDTAI.
        /// </summary>
        public const string DIDTAI = "DIDTAI";

        /// <summary>
        /// DIFRDV.
        /// </summary>
        public const string DIFRDV = "DIFRDV";

        /// <summary>
        /// DIOWDI.
        /// </summary>
        public const string DIOWDI = "DIOWDI";

        /// <summary>
        /// DIFMNM.
        /// </summary>
        public const string DIFMNM = "DIFMNM";

        /// <summary>
        /// DIFUNO.
        /// </summary>
        public const string DIFUNO = "DIFUNO";

        /// <summary>
        /// DIINSL.
        /// </summary>
        public const string DIINSL = "DIINSL";

        /// <summary>
        /// DIRUN.
        /// </summary>
        public const string DIRUN = "DIRUN";

        /// <summary>
        /// DIVWYN.
        /// </summary>
        public const string DIVWYN = "DIVWYN";

        /// <summary>
        /// DIA.
        /// </summary>
        public const string DIA = "DIA";

        /// <summary>
        /// DICHNG.
        /// </summary>
        public const string DICHNG = "DICHNG";

        /// <summary>
        /// DIDLT.
        /// </summary>
        public const string DIDLT = "DIDLT";

        /// <summary>
        /// DISY.
        /// </summary>
        public const string DISY = "DISY";

        /// <summary>
        /// DITHDV.
        /// </summary>
        public const string DITHDV = "DITHDV";

        /// <summary>
        /// DIOBID.
        /// </summary>
        public const string DIOBID = "DIOBID";

        /// <summary>
        /// DIADDC.
        /// </summary>
        public const string DIADDC = "DIADDC";

        /// <summary>
        /// DIIOK.
        /// </summary>
        public const string DIIOK = "DIIOK";

        /// <summary>
        /// DIICPY.
        /// </summary>
        public const string DIICPY = "DIICPY";

        /// <summary>
        /// DIIUPT.
        /// </summary>
        public const string DIIUPT = "DIIUPT";

        /// <summary>
        /// DIATN1.
        /// </summary>
        public const string DIATN1 = "DIATN1";

        /// <summary>
        /// DIATN2.
        /// </summary>
        public const string DIATN2 = "DIATN2";

        /// <summary>
        /// DIATN3.
        /// </summary>
        public const string DIATN3 = "DIATN3";

        /// <summary>
        /// DIMUSE.
        /// </summary>
        public const string DIMUSE = "DIMUSE";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIEXITID.
        /// </summary>
        public const string DIEXITID = "DIEXITID";

        /// <summary>
        /// DITABID.
        /// </summary>
        public const string DITABID = "DITABID";

        /// <summary>
        /// DITEXTID.
        /// </summary>
        public const string DITEXTID = "DITEXTID";

        /// <summary>
        /// DIPTH.
        /// </summary>
        public const string DIPTH = "DIPTH";

        /// <summary>
        /// DIY5AFAPTP.
        /// </summary>
        public const string DIY5AFAPTP = "DIY5AFAPTP";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX07";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIY5AFTMPL", "DIY5AFTMPL", JdeDataType.String, 20, true, true),
        new JdeField("DISETY", "DISETY", JdeDataType.String, 2, true, true),
        new JdeField("DIY5AFCPID", "DIY5AFCPID", JdeDataType.String, 20, true, true),
        new JdeField("DIOBNM", "DIOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DIDTAI", "DIDTAI", JdeDataType.String, 20, true, true),
        new JdeField("DIFRDV", "DIFRDV", JdeDataType.String, 60, true, true),
        new JdeField("DIOWDI", "DIOWDI", JdeDataType.String, 80),
        new JdeField("DIFMNM", "DIFMNM", JdeDataType.String, 20),
        new JdeField("DIFUNO", "DIFUNO", JdeDataType.String, 8),
        new JdeField("DIINSL", "DIINSL", JdeDataType.String, 2),
        new JdeField("DIRUN", "DIRUN", JdeDataType.String, 2),
        new JdeField("DIVWYN", "DIVWYN", JdeDataType.String, 2),
        new JdeField("DIA", "DIA", JdeDataType.String, 2),
        new JdeField("DICHNG", "DICHNG", JdeDataType.String, 2),
        new JdeField("DIDLT", "DIDLT", JdeDataType.String, 2),
        new JdeField("DISY", "DISY", JdeDataType.String, 8, true, true),
        new JdeField("DITHDV", "DITHDV", JdeDataType.String, 60),
        new JdeField("DIOBID", "DIOBID", JdeDataType.Numeric),
        new JdeField("DIADDC", "DIADDC", JdeDataType.String, 2),
        new JdeField("DIIOK", "DIIOK", JdeDataType.String, 2),
        new JdeField("DIICPY", "DIICPY", JdeDataType.String, 2),
        new JdeField("DIIUPT", "DIIUPT", JdeDataType.String, 2),
        new JdeField("DIATN1", "DIATN1", JdeDataType.String, 2),
        new JdeField("DIATN2", "DIATN2", JdeDataType.String, 2),
        new JdeField("DIATN3", "DIATN3", JdeDataType.String, 2),
        new JdeField("DIMUSE", "DIMUSE", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("DIEXITID", "DIEXITID", JdeDataType.Numeric),
        new JdeField("DITABID", "DITABID", JdeDataType.Numeric),
        new JdeField("DITEXTID", "DITEXTID", JdeDataType.Numeric),
        new JdeField("DIPTH", "DIPTH", JdeDataType.String, 240),
        new JdeField("DIY5AFAPTP", "DIY5AFAPTP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX07_0", "Primary Key on DIY5AFTMPL, DISETY, DIY5AFCPID, DIOBNM, DIDTAI, DIFRDV, DISY, DIUPMJ, DIUPMT", new[] { "DIY5AFTMPL", "DISETY", "DIY5AFCPID", "DIOBNM", "DIDTAI", "DIFRDV", "DISY", "DIUPMJ", "DIUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX07_2", "Index on DIY5AFTMPL, DISETY, DIY5AFCPID, DIOBNM, DISY", new[] { "DIY5AFTMPL", "DISETY", "DIY5AFCPID", "DIOBNM", "DISY" }),
        new JdeIndex("FY5AFX07_3", "Index on DIY5AFTMPL, DISETY, DIY5AFCPID, DIOBNM, DIOBID", new[] { "DIY5AFTMPL", "DISETY", "DIY5AFCPID", "DIOBNM", "DIOBID" }),
        new JdeIndex("FY5AFX07_4", "Index on DIY5AFTMPL, DISETY, DIY5AFCPID, DIOBNM, DIFMNM, DIEXITID", new[] { "DIY5AFTMPL", "DISETY", "DIY5AFCPID", "DIOBNM", "DIFMNM", "DIEXITID" }),
        new JdeIndex("FY5AFX07_5", "Index on DIY5AFTMPL, DISETY, DIY5AFCPID, DIOBNM, DIFMNM, DITABID", new[] { "DIY5AFTMPL", "DISETY", "DIY5AFCPID", "DIOBNM", "DIFMNM", "DITABID" }),
        new JdeIndex("FY5AFX07_6", "Index on DIY5AFTMPL, DISETY, DIY5AFCPID, DIPTH", new[] { "DIY5AFTMPL", "DISETY", "DIY5AFCPID", "DIPTH" }),
        new JdeIndex("FY5AFX07_7", "Index on DIY5AFTMPL, DISETY, DIOBNM", new[] { "DIY5AFTMPL", "DISETY", "DIOBNM" }),
        new JdeIndex("FY5AFX07_8", "Index on DIY5AFTMPL, DIY5AFCPID", new[] { "DIY5AFTMPL", "DIY5AFCPID" })
    };
}
