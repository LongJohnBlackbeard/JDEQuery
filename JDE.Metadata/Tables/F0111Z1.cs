using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0111Z1 - .
/// </summary>
public class F0111Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWEDUS.
        /// </summary>
        public const string BWEDUS = "BWEDUS";

        /// <summary>
        /// BWEDBT.
        /// </summary>
        public const string BWEDBT = "BWEDBT";

        /// <summary>
        /// BWEDTN.
        /// </summary>
        public const string BWEDTN = "BWEDTN";

        /// <summary>
        /// BWEDLN.
        /// </summary>
        public const string BWEDLN = "BWEDLN";

        /// <summary>
        /// BWEDCT.
        /// </summary>
        public const string BWEDCT = "BWEDCT";

        /// <summary>
        /// BWTYTN.
        /// </summary>
        public const string BWTYTN = "BWTYTN";

        /// <summary>
        /// BWEDFT.
        /// </summary>
        public const string BWEDFT = "BWEDFT";

        /// <summary>
        /// BWEDDT.
        /// </summary>
        public const string BWEDDT = "BWEDDT";

        /// <summary>
        /// BWDRIN.
        /// </summary>
        public const string BWDRIN = "BWDRIN";

        /// <summary>
        /// BWEDDL.
        /// </summary>
        public const string BWEDDL = "BWEDDL";

        /// <summary>
        /// BWEDSP.
        /// </summary>
        public const string BWEDSP = "BWEDSP";

        /// <summary>
        /// BWPNID.
        /// </summary>
        public const string BWPNID = "BWPNID";

        /// <summary>
        /// BWTNAC.
        /// </summary>
        public const string BWTNAC = "BWTNAC";

        /// <summary>
        /// BWAN8.
        /// </summary>
        public const string BWAN8 = "BWAN8";

        /// <summary>
        /// BWIDLN.
        /// </summary>
        public const string BWIDLN = "BWIDLN";

        /// <summary>
        /// BWDSS5.
        /// </summary>
        public const string BWDSS5 = "BWDSS5";

        /// <summary>
        /// BWMLNM.
        /// </summary>
        public const string BWMLNM = "BWMLNM";

        /// <summary>
        /// BWATTL.
        /// </summary>
        public const string BWATTL = "BWATTL";

        /// <summary>
        /// BWREM1.
        /// </summary>
        public const string BWREM1 = "BWREM1";

        /// <summary>
        /// BWSLNM.
        /// </summary>
        public const string BWSLNM = "BWSLNM";

        /// <summary>
        /// BWALPH.
        /// </summary>
        public const string BWALPH = "BWALPH";

        /// <summary>
        /// BWDC.
        /// </summary>
        public const string BWDC = "BWDC";

        /// <summary>
        /// BWGNNM.
        /// </summary>
        public const string BWGNNM = "BWGNNM";

        /// <summary>
        /// BWMDNM.
        /// </summary>
        public const string BWMDNM = "BWMDNM";

        /// <summary>
        /// BWSRNM.
        /// </summary>
        public const string BWSRNM = "BWSRNM";

        /// <summary>
        /// BWTYC.
        /// </summary>
        public const string BWTYC = "BWTYC";

        /// <summary>
        /// BWW001.
        /// </summary>
        public const string BWW001 = "BWW001";

        /// <summary>
        /// BWW002.
        /// </summary>
        public const string BWW002 = "BWW002";

        /// <summary>
        /// BWW003.
        /// </summary>
        public const string BWW003 = "BWW003";

        /// <summary>
        /// BWW004.
        /// </summary>
        public const string BWW004 = "BWW004";

        /// <summary>
        /// BWW005.
        /// </summary>
        public const string BWW005 = "BWW005";

        /// <summary>
        /// BWW006.
        /// </summary>
        public const string BWW006 = "BWW006";

        /// <summary>
        /// BWW007.
        /// </summary>
        public const string BWW007 = "BWW007";

        /// <summary>
        /// BWW008.
        /// </summary>
        public const string BWW008 = "BWW008";

        /// <summary>
        /// BWW009.
        /// </summary>
        public const string BWW009 = "BWW009";

        /// <summary>
        /// BWW010.
        /// </summary>
        public const string BWW010 = "BWW010";

        /// <summary>
        /// BWMLN1.
        /// </summary>
        public const string BWMLN1 = "BWMLN1";

        /// <summary>
        /// BWALP1.
        /// </summary>
        public const string BWALP1 = "BWALP1";

        /// <summary>
        /// BWTORG.
        /// </summary>
        public const string BWTORG = "BWTORG";

        /// <summary>
        /// BWUSER.
        /// </summary>
        public const string BWUSER = "BWUSER";

        /// <summary>
        /// BWPID.
        /// </summary>
        public const string BWPID = "BWPID";

        /// <summary>
        /// BWUPMJ.
        /// </summary>
        public const string BWUPMJ = "BWUPMJ";

        /// <summary>
        /// BWJOBN.
        /// </summary>
        public const string BWJOBN = "BWJOBN";

        /// <summary>
        /// BWTDAY.
        /// </summary>
        public const string BWTDAY = "BWTDAY";

        /// <summary>
        /// BWUPMT.
        /// </summary>
        public const string BWUPMT = "BWUPMT";

        /// <summary>
        /// BWWN001.
        /// </summary>
        public const string BWWN001 = "BWWN001";

        /// <summary>
        /// BWWN002.
        /// </summary>
        public const string BWWN002 = "BWWN002";

        /// <summary>
        /// BWWN003.
        /// </summary>
        public const string BWWN003 = "BWWN003";

        /// <summary>
        /// BWWN004.
        /// </summary>
        public const string BWWN004 = "BWWN004";

        /// <summary>
        /// BWWN005.
        /// </summary>
        public const string BWWN005 = "BWWN005";

        /// <summary>
        /// BWWN006.
        /// </summary>
        public const string BWWN006 = "BWWN006";

        /// <summary>
        /// BWWN007.
        /// </summary>
        public const string BWWN007 = "BWWN007";

        /// <summary>
        /// BWWN008.
        /// </summary>
        public const string BWWN008 = "BWWN008";

        /// <summary>
        /// BWWN009.
        /// </summary>
        public const string BWWN009 = "BWWN009";

        /// <summary>
        /// BWWN010.
        /// </summary>
        public const string BWWN010 = "BWWN010";

        /// <summary>
        /// BWNICK.
        /// </summary>
        public const string BWNICK = "BWNICK";

        /// <summary>
        /// BWGEND.
        /// </summary>
        public const string BWGEND = "BWGEND";

        /// <summary>
        /// BWNTYP.
        /// </summary>
        public const string BWNTYP = "BWNTYP";

        /// <summary>
        /// BWDDATE.
        /// </summary>
        public const string BWDDATE = "BWDDATE";

        /// <summary>
        /// BWDMON.
        /// </summary>
        public const string BWDMON = "BWDMON";

        /// <summary>
        /// BWDYR.
        /// </summary>
        public const string BWDYR = "BWDYR";

        /// <summary>
        /// BWFUCO.
        /// </summary>
        public const string BWFUCO = "BWFUCO";

        /// <summary>
        /// BWPCM.
        /// </summary>
        public const string BWPCM = "BWPCM";

        /// <summary>
        /// BWPCF.
        /// </summary>
        public const string BWPCF = "BWPCF";

        /// <summary>
        /// BWACTIN.
        /// </summary>
        public const string BWACTIN = "BWACTIN";

        /// <summary>
        /// BWCFRGUID.
        /// </summary>
        public const string BWCFRGUID = "BWCFRGUID";

        /// <summary>
        /// BWREFNAME.
        /// </summary>
        public const string BWREFNAME = "BWREFNAME";

        /// <summary>
        /// BWCHPROC.
        /// </summary>
        public const string BWCHPROC = "BWCHPROC";
    }

    /// <inheritdoc />
    public override string TableName => "F0111Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWEDUS", "BWEDUS", JdeDataType.String, 20, true, true),
        new JdeField("BWEDBT", "BWEDBT", JdeDataType.String, 30, true, true),
        new JdeField("BWEDTN", "BWEDTN", JdeDataType.String, 44, true, true),
        new JdeField("BWEDLN", "BWEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWEDCT", "BWEDCT", JdeDataType.String, 4),
        new JdeField("BWTYTN", "BWTYTN", JdeDataType.String, 16),
        new JdeField("BWEDFT", "BWEDFT", JdeDataType.String, 20),
        new JdeField("BWEDDT", "BWEDDT", JdeDataType.Numeric),
        new JdeField("BWDRIN", "BWDRIN", JdeDataType.String, 2),
        new JdeField("BWEDDL", "BWEDDL", JdeDataType.Numeric),
        new JdeField("BWEDSP", "BWEDSP", JdeDataType.String, 2),
        new JdeField("BWPNID", "BWPNID", JdeDataType.String, 30),
        new JdeField("BWTNAC", "BWTNAC", JdeDataType.String, 4),
        new JdeField("BWAN8", "BWAN8", JdeDataType.Numeric),
        new JdeField("BWIDLN", "BWIDLN", JdeDataType.Numeric),
        new JdeField("BWDSS5", "BWDSS5", JdeDataType.Numeric),
        new JdeField("BWMLNM", "BWMLNM", JdeDataType.String, 80),
        new JdeField("BWATTL", "BWATTL", JdeDataType.String, 80),
        new JdeField("BWREM1", "BWREM1", JdeDataType.String, 80),
        new JdeField("BWSLNM", "BWSLNM", JdeDataType.String, 80),
        new JdeField("BWALPH", "BWALPH", JdeDataType.String, 80),
        new JdeField("BWDC", "BWDC", JdeDataType.String, 80),
        new JdeField("BWGNNM", "BWGNNM", JdeDataType.String, 50),
        new JdeField("BWMDNM", "BWMDNM", JdeDataType.String, 50),
        new JdeField("BWSRNM", "BWSRNM", JdeDataType.String, 50),
        new JdeField("BWTYC", "BWTYC", JdeDataType.String, 2),
        new JdeField("BWW001", "BWW001", JdeDataType.String, 6),
        new JdeField("BWW002", "BWW002", JdeDataType.String, 6),
        new JdeField("BWW003", "BWW003", JdeDataType.String, 6),
        new JdeField("BWW004", "BWW004", JdeDataType.String, 6),
        new JdeField("BWW005", "BWW005", JdeDataType.String, 6),
        new JdeField("BWW006", "BWW006", JdeDataType.String, 6),
        new JdeField("BWW007", "BWW007", JdeDataType.String, 6),
        new JdeField("BWW008", "BWW008", JdeDataType.String, 6),
        new JdeField("BWW009", "BWW009", JdeDataType.String, 6),
        new JdeField("BWW010", "BWW010", JdeDataType.String, 6),
        new JdeField("BWMLN1", "BWMLN1", JdeDataType.String, 80),
        new JdeField("BWALP1", "BWALP1", JdeDataType.String, 80),
        new JdeField("BWTORG", "BWTORG", JdeDataType.String, 20),
        new JdeField("BWUSER", "BWUSER", JdeDataType.String, 20),
        new JdeField("BWPID", "BWPID", JdeDataType.String, 20),
        new JdeField("BWUPMJ", "BWUPMJ", JdeDataType.Numeric),
        new JdeField("BWJOBN", "BWJOBN", JdeDataType.String, 20),
        new JdeField("BWTDAY", "BWTDAY", JdeDataType.Numeric),
        new JdeField("BWUPMT", "BWUPMT", JdeDataType.Numeric),
        new JdeField("BWWN001", "BWWN001", JdeDataType.String, 6),
        new JdeField("BWWN002", "BWWN002", JdeDataType.String, 6),
        new JdeField("BWWN003", "BWWN003", JdeDataType.String, 6),
        new JdeField("BWWN004", "BWWN004", JdeDataType.String, 6),
        new JdeField("BWWN005", "BWWN005", JdeDataType.String, 6),
        new JdeField("BWWN006", "BWWN006", JdeDataType.String, 6),
        new JdeField("BWWN007", "BWWN007", JdeDataType.String, 6),
        new JdeField("BWWN008", "BWWN008", JdeDataType.String, 6),
        new JdeField("BWWN009", "BWWN009", JdeDataType.String, 6),
        new JdeField("BWWN010", "BWWN010", JdeDataType.String, 6),
        new JdeField("BWNICK", "BWNICK", JdeDataType.String, 80),
        new JdeField("BWGEND", "BWGEND", JdeDataType.String, 2),
        new JdeField("BWNTYP", "BWNTYP", JdeDataType.String, 6),
        new JdeField("BWDDATE", "BWDDATE", JdeDataType.Numeric),
        new JdeField("BWDMON", "BWDMON", JdeDataType.Numeric),
        new JdeField("BWDYR", "BWDYR", JdeDataType.Numeric),
        new JdeField("BWFUCO", "BWFUCO", JdeDataType.String, 20),
        new JdeField("BWPCM", "BWPCM", JdeDataType.String, 20),
        new JdeField("BWPCF", "BWPCF", JdeDataType.String, 6),
        new JdeField("BWACTIN", "BWACTIN", JdeDataType.String, 2),
        new JdeField("BWCFRGUID", "BWCFRGUID", JdeDataType.String, 72),
        new JdeField("BWREFNAME", "BWREFNAME", JdeDataType.String, 80),
        new JdeField("BWCHPROC", "BWCHPROC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0111Z1_0", "Primary Key on BWEDUS, BWEDBT, BWEDTN, BWEDLN", new[] { "BWEDUS", "BWEDBT", "BWEDTN", "BWEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0111Z1_2", "Index on BWCFRGUID", new[] { "BWCFRGUID" })
    };
}
