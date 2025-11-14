using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX02 - .
/// </summary>
public class FY5AFX02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIMNI.
        /// </summary>
        public const string DIMNI = "DIMNI";

        /// <summary>
        /// DISELN.
        /// </summary>
        public const string DISELN = "DISELN";

        /// <summary>
        /// DIJTOE.
        /// </summary>
        public const string DIJTOE = "DIJTOE";

        /// <summary>
        /// DISBTD.
        /// </summary>
        public const string DISBTD = "DISBTD";

        /// <summary>
        /// DIHSKY.
        /// </summary>
        public const string DIHSKY = "DIHSKY";

        /// <summary>
        /// DIOPCD.
        /// </summary>
        public const string DIOPCD = "DIOPCD";

        /// <summary>
        /// DIOPKY.
        /// </summary>
        public const string DIOPKY = "DIOPKY";

        /// <summary>
        /// DIVER.
        /// </summary>
        public const string DIVER = "DIVER";

        /// <summary>
        /// DIRMSG.
        /// </summary>
        public const string DIRMSG = "DIRMSG";

        /// <summary>
        /// DIXHL.
        /// </summary>
        public const string DIXHL = "DIXHL";

        /// <summary>
        /// DIMTOE.
        /// </summary>
        public const string DIMTOE = "DIMTOE";

        /// <summary>
        /// DISLTY.
        /// </summary>
        public const string DISLTY = "DISLTY";

        /// <summary>
        /// DIMCTR.
        /// </summary>
        public const string DIMCTR = "DIMCTR";

        /// <summary>
        /// DISYAO.
        /// </summary>
        public const string DISYAO = "DISYAO";

        /// <summary>
        /// DIPOID.
        /// </summary>
        public const string DIPOID = "DIPOID";

        /// <summary>
        /// DIAPPI.
        /// </summary>
        public const string DIAPPI = "DIAPPI";

        /// <summary>
        /// DIFMID.
        /// </summary>
        public const string DIFMID = "DIFMID";

        /// <summary>
        /// DIICNI.
        /// </summary>
        public const string DIICNI = "DIICNI";

        /// <summary>
        /// DIRNMF.
        /// </summary>
        public const string DIRNMF = "DIRNMF";

        /// <summary>
        /// DISLCS.
        /// </summary>
        public const string DISLCS = "DISLCS";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIMSKA.
        /// </summary>
        public const string DIMSKA = "DIMSKA";

        /// <summary>
        /// DIMSKJ.
        /// </summary>
        public const string DIMSKJ = "DIMSKJ";

        /// <summary>
        /// DIMSKK.
        /// </summary>
        public const string DIMSKK = "DIMSKK";

        /// <summary>
        /// DIMSKD.
        /// </summary>
        public const string DIMSKD = "DIMSKD";

        /// <summary>
        /// DIMSKF.
        /// </summary>
        public const string DIMSKF = "DIMSKF";

        /// <summary>
        /// DIOBNM.
        /// </summary>
        public const string DIOBNM = "DIOBNM";

        /// <summary>
        /// DIFMNM.
        /// </summary>
        public const string DIFMNM = "DIFMNM";

        /// <summary>
        /// DISY.
        /// </summary>
        public const string DISY = "DISY";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIMNI", "DIMNI", JdeDataType.String, 20, true, true),
        new JdeField("DISELN", "DISELN", JdeDataType.Numeric, null, true, true),
        new JdeField("DIJTOE", "DIJTOE", JdeDataType.String, 20),
        new JdeField("DISBTD", "DISBTD", JdeDataType.String, 2),
        new JdeField("DIHSKY", "DIHSKY", JdeDataType.String, 20),
        new JdeField("DIOPCD", "DIOPCD", JdeDataType.String, 2),
        new JdeField("DIOPKY", "DIOPKY", JdeDataType.String, 20),
        new JdeField("DIVER", "DIVER", JdeDataType.String, 20),
        new JdeField("DIRMSG", "DIRMSG", JdeDataType.String, 20),
        new JdeField("DIXHL", "DIXHL", JdeDataType.String, 2),
        new JdeField("DIMTOE", "DIMTOE", JdeDataType.String, 20),
        new JdeField("DISLTY", "DISLTY", JdeDataType.String, 2),
        new JdeField("DIMCTR", "DIMCTR", JdeDataType.String, 6),
        new JdeField("DISYAO", "DISYAO", JdeDataType.String, 8),
        new JdeField("DIPOID", "DIPOID", JdeDataType.Numeric),
        new JdeField("DIAPPI", "DIAPPI", JdeDataType.Numeric),
        new JdeField("DIFMID", "DIFMID", JdeDataType.Numeric),
        new JdeField("DIICNI", "DIICNI", JdeDataType.Numeric),
        new JdeField("DIRNMF", "DIRNMF", JdeDataType.String, 2),
        new JdeField("DISLCS", "DISLCS", JdeDataType.String, 2),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIMSKA", "DIMSKA", JdeDataType.String, 2),
        new JdeField("DIMSKJ", "DIMSKJ", JdeDataType.String, 2),
        new JdeField("DIMSKK", "DIMSKK", JdeDataType.String, 2),
        new JdeField("DIMSKD", "DIMSKD", JdeDataType.String, 4),
        new JdeField("DIMSKF", "DIMSKF", JdeDataType.String, 2),
        new JdeField("DIOBNM", "DIOBNM", JdeDataType.String, 20),
        new JdeField("DIFMNM", "DIFMNM", JdeDataType.String, 20),
        new JdeField("DISY", "DISY", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX02_0", "Primary Key on DIMNI, DISELN", new[] { "DIMNI", "DISELN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX02_2", "Index on DIJTOE, DIMNI, DISLTY", new[] { "DIJTOE", "DIMNI", "DISLTY" }),
        new JdeIndex("FY5AFX02_3", "Index on DIMNI, DIMTOE, DISLTY", new[] { "DIMNI", "DIMTOE", "DISLTY" }),
        new JdeIndex("FY5AFX02_4", "Index on DIMNI, DISLTY", new[] { "DIMNI", "DISLTY" }),
        new JdeIndex("FY5AFX02_5", "Index on DIOPKY, DIVER, DIMNI, DISLTY", new[] { "DIOPKY", "DIVER", "DIMNI", "DISLTY" }),
        new JdeIndex("FY5AFX02_6", "Index on DIOBNM, DIVER, DIMNI, DISLTY", new[] { "DIOBNM", "DIVER", "DIMNI", "DISLTY" }),
        new JdeIndex("FY5AFX02_7", "Index on DISY", new[] { "DISY" })
    };
}
