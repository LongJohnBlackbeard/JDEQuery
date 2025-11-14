using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0111 - .
/// </summary>
public class F0111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WWAN8.
        /// </summary>
        public const string WWAN8 = "WWAN8";

        /// <summary>
        /// WWIDLN.
        /// </summary>
        public const string WWIDLN = "WWIDLN";

        /// <summary>
        /// WWDSS5.
        /// </summary>
        public const string WWDSS5 = "WWDSS5";

        /// <summary>
        /// WWMLNM.
        /// </summary>
        public const string WWMLNM = "WWMLNM";

        /// <summary>
        /// WWATTL.
        /// </summary>
        public const string WWATTL = "WWATTL";

        /// <summary>
        /// WWREM1.
        /// </summary>
        public const string WWREM1 = "WWREM1";

        /// <summary>
        /// WWSLNM.
        /// </summary>
        public const string WWSLNM = "WWSLNM";

        /// <summary>
        /// WWALPH.
        /// </summary>
        public const string WWALPH = "WWALPH";

        /// <summary>
        /// WWDC.
        /// </summary>
        public const string WWDC = "WWDC";

        /// <summary>
        /// WWGNNM.
        /// </summary>
        public const string WWGNNM = "WWGNNM";

        /// <summary>
        /// WWMDNM.
        /// </summary>
        public const string WWMDNM = "WWMDNM";

        /// <summary>
        /// WWSRNM.
        /// </summary>
        public const string WWSRNM = "WWSRNM";

        /// <summary>
        /// WWTYC.
        /// </summary>
        public const string WWTYC = "WWTYC";

        /// <summary>
        /// WWW001.
        /// </summary>
        public const string WWW001 = "WWW001";

        /// <summary>
        /// WWW002.
        /// </summary>
        public const string WWW002 = "WWW002";

        /// <summary>
        /// WWW003.
        /// </summary>
        public const string WWW003 = "WWW003";

        /// <summary>
        /// WWW004.
        /// </summary>
        public const string WWW004 = "WWW004";

        /// <summary>
        /// WWW005.
        /// </summary>
        public const string WWW005 = "WWW005";

        /// <summary>
        /// WWW006.
        /// </summary>
        public const string WWW006 = "WWW006";

        /// <summary>
        /// WWW007.
        /// </summary>
        public const string WWW007 = "WWW007";

        /// <summary>
        /// WWW008.
        /// </summary>
        public const string WWW008 = "WWW008";

        /// <summary>
        /// WWW009.
        /// </summary>
        public const string WWW009 = "WWW009";

        /// <summary>
        /// WWW010.
        /// </summary>
        public const string WWW010 = "WWW010";

        /// <summary>
        /// WWMLN1.
        /// </summary>
        public const string WWMLN1 = "WWMLN1";

        /// <summary>
        /// WWALP1.
        /// </summary>
        public const string WWALP1 = "WWALP1";

        /// <summary>
        /// WWUSER.
        /// </summary>
        public const string WWUSER = "WWUSER";

        /// <summary>
        /// WWPID.
        /// </summary>
        public const string WWPID = "WWPID";

        /// <summary>
        /// WWUPMJ.
        /// </summary>
        public const string WWUPMJ = "WWUPMJ";

        /// <summary>
        /// WWJOBN.
        /// </summary>
        public const string WWJOBN = "WWJOBN";

        /// <summary>
        /// WWUPMT.
        /// </summary>
        public const string WWUPMT = "WWUPMT";

        /// <summary>
        /// WWNTYP.
        /// </summary>
        public const string WWNTYP = "WWNTYP";

        /// <summary>
        /// WWNICK.
        /// </summary>
        public const string WWNICK = "WWNICK";

        /// <summary>
        /// WWGEND.
        /// </summary>
        public const string WWGEND = "WWGEND";

        /// <summary>
        /// WWDDATE.
        /// </summary>
        public const string WWDDATE = "WWDDATE";

        /// <summary>
        /// WWDMON.
        /// </summary>
        public const string WWDMON = "WWDMON";

        /// <summary>
        /// WWDYR.
        /// </summary>
        public const string WWDYR = "WWDYR";

        /// <summary>
        /// WWWN001.
        /// </summary>
        public const string WWWN001 = "WWWN001";

        /// <summary>
        /// WWWN002.
        /// </summary>
        public const string WWWN002 = "WWWN002";

        /// <summary>
        /// WWWN003.
        /// </summary>
        public const string WWWN003 = "WWWN003";

        /// <summary>
        /// WWWN004.
        /// </summary>
        public const string WWWN004 = "WWWN004";

        /// <summary>
        /// WWWN005.
        /// </summary>
        public const string WWWN005 = "WWWN005";

        /// <summary>
        /// WWWN006.
        /// </summary>
        public const string WWWN006 = "WWWN006";

        /// <summary>
        /// WWWN007.
        /// </summary>
        public const string WWWN007 = "WWWN007";

        /// <summary>
        /// WWWN008.
        /// </summary>
        public const string WWWN008 = "WWWN008";

        /// <summary>
        /// WWWN009.
        /// </summary>
        public const string WWWN009 = "WWWN009";

        /// <summary>
        /// WWWN010.
        /// </summary>
        public const string WWWN010 = "WWWN010";

        /// <summary>
        /// WWFUCO.
        /// </summary>
        public const string WWFUCO = "WWFUCO";

        /// <summary>
        /// WWPCM.
        /// </summary>
        public const string WWPCM = "WWPCM";

        /// <summary>
        /// WWPCF.
        /// </summary>
        public const string WWPCF = "WWPCF";

        /// <summary>
        /// WWACTIN.
        /// </summary>
        public const string WWACTIN = "WWACTIN";

        /// <summary>
        /// WWCFRGUID.
        /// </summary>
        public const string WWCFRGUID = "WWCFRGUID";

        /// <summary>
        /// WWSYNCS.
        /// </summary>
        public const string WWSYNCS = "WWSYNCS";

        /// <summary>
        /// WWCAAD.
        /// </summary>
        public const string WWCAAD = "WWCAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F0111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WWAN8", "WWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WWIDLN", "WWIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WWDSS5", "WWDSS5", JdeDataType.Numeric),
        new JdeField("WWMLNM", "WWMLNM", JdeDataType.String, 80),
        new JdeField("WWATTL", "WWATTL", JdeDataType.String, 80),
        new JdeField("WWREM1", "WWREM1", JdeDataType.String, 80),
        new JdeField("WWSLNM", "WWSLNM", JdeDataType.String, 80),
        new JdeField("WWALPH", "WWALPH", JdeDataType.String, 80),
        new JdeField("WWDC", "WWDC", JdeDataType.String, 80),
        new JdeField("WWGNNM", "WWGNNM", JdeDataType.String, 50),
        new JdeField("WWMDNM", "WWMDNM", JdeDataType.String, 50),
        new JdeField("WWSRNM", "WWSRNM", JdeDataType.String, 50),
        new JdeField("WWTYC", "WWTYC", JdeDataType.String, 2),
        new JdeField("WWW001", "WWW001", JdeDataType.String, 6),
        new JdeField("WWW002", "WWW002", JdeDataType.String, 6),
        new JdeField("WWW003", "WWW003", JdeDataType.String, 6),
        new JdeField("WWW004", "WWW004", JdeDataType.String, 6),
        new JdeField("WWW005", "WWW005", JdeDataType.String, 6),
        new JdeField("WWW006", "WWW006", JdeDataType.String, 6),
        new JdeField("WWW007", "WWW007", JdeDataType.String, 6),
        new JdeField("WWW008", "WWW008", JdeDataType.String, 6),
        new JdeField("WWW009", "WWW009", JdeDataType.String, 6),
        new JdeField("WWW010", "WWW010", JdeDataType.String, 6),
        new JdeField("WWMLN1", "WWMLN1", JdeDataType.String, 80),
        new JdeField("WWALP1", "WWALP1", JdeDataType.String, 80),
        new JdeField("WWUSER", "WWUSER", JdeDataType.String, 20),
        new JdeField("WWPID", "WWPID", JdeDataType.String, 20),
        new JdeField("WWUPMJ", "WWUPMJ", JdeDataType.Numeric),
        new JdeField("WWJOBN", "WWJOBN", JdeDataType.String, 20),
        new JdeField("WWUPMT", "WWUPMT", JdeDataType.Numeric),
        new JdeField("WWNTYP", "WWNTYP", JdeDataType.String, 6),
        new JdeField("WWNICK", "WWNICK", JdeDataType.String, 80),
        new JdeField("WWGEND", "WWGEND", JdeDataType.String, 2),
        new JdeField("WWDDATE", "WWDDATE", JdeDataType.Numeric),
        new JdeField("WWDMON", "WWDMON", JdeDataType.Numeric),
        new JdeField("WWDYR", "WWDYR", JdeDataType.Numeric),
        new JdeField("WWWN001", "WWWN001", JdeDataType.String, 6),
        new JdeField("WWWN002", "WWWN002", JdeDataType.String, 6),
        new JdeField("WWWN003", "WWWN003", JdeDataType.String, 6),
        new JdeField("WWWN004", "WWWN004", JdeDataType.String, 6),
        new JdeField("WWWN005", "WWWN005", JdeDataType.String, 6),
        new JdeField("WWWN006", "WWWN006", JdeDataType.String, 6),
        new JdeField("WWWN007", "WWWN007", JdeDataType.String, 6),
        new JdeField("WWWN008", "WWWN008", JdeDataType.String, 6),
        new JdeField("WWWN009", "WWWN009", JdeDataType.String, 6),
        new JdeField("WWWN010", "WWWN010", JdeDataType.String, 6),
        new JdeField("WWFUCO", "WWFUCO", JdeDataType.String, 20),
        new JdeField("WWPCM", "WWPCM", JdeDataType.String, 20),
        new JdeField("WWPCF", "WWPCF", JdeDataType.String, 6),
        new JdeField("WWACTIN", "WWACTIN", JdeDataType.String, 2),
        new JdeField("WWCFRGUID", "WWCFRGUID", JdeDataType.String, 72),
        new JdeField("WWSYNCS", "WWSYNCS", JdeDataType.Numeric),
        new JdeField("WWCAAD", "WWCAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0111_0", "Primary Key on WWAN8, WWIDLN", new[] { "WWAN8", "WWIDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0111_2", "Index on WWAN8, WWTYC", new[] { "WWAN8", "WWTYC" }),
        new JdeIndex("F0111_3", "Index on WWCFRGUID", new[] { "WWCFRGUID" })
    };
}
