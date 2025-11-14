using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07355 - .
/// </summary>
public class F07355 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y5PAYD.
        /// </summary>
        public const string Y5PAYD = "Y5PAYD";

        /// <summary>
        /// Y5PID.
        /// </summary>
        public const string Y5PID = "Y5PID";

        /// <summary>
        /// Y5AN8.
        /// </summary>
        public const string Y5AN8 = "Y5AN8";

        /// <summary>
        /// Y5LIID.
        /// </summary>
        public const string Y5LIID = "Y5LIID";

        /// <summary>
        /// Y5ALPH.
        /// </summary>
        public const string Y5ALPH = "Y5ALPH";

        /// <summary>
        /// Y5DL01.
        /// </summary>
        public const string Y5DL01 = "Y5DL01";

        /// <summary>
        /// Y5DL02.
        /// </summary>
        public const string Y5DL02 = "Y5DL02";

        /// <summary>
        /// Y5GPA.
        /// </summary>
        public const string Y5GPA = "Y5GPA";

        /// <summary>
        /// Y5G101.
        /// </summary>
        public const string Y5G101 = "Y5G101";

        /// <summary>
        /// Y5G102.
        /// </summary>
        public const string Y5G102 = "Y5G102";

        /// <summary>
        /// Y5G103.
        /// </summary>
        public const string Y5G103 = "Y5G103";

        /// <summary>
        /// Y5PHRW.
        /// </summary>
        public const string Y5PHRW = "Y5PHRW";

        /// <summary>
        /// Y5ARRA.
        /// </summary>
        public const string Y5ARRA = "Y5ARRA";

        /// <summary>
        /// Y5GPAY.
        /// </summary>
        public const string Y5GPAY = "Y5GPAY";

        /// <summary>
        /// Y5USR.
        /// </summary>
        public const string Y5USR = "Y5USR";

        /// <summary>
        /// Y5PDBA.
        /// </summary>
        public const string Y5PDBA = "Y5PDBA";

        /// <summary>
        /// Y5DISO.
        /// </summary>
        public const string Y5DISO = "Y5DISO";

        /// <summary>
        /// Y5EKEY.
        /// </summary>
        public const string Y5EKEY = "Y5EKEY";

        /// <summary>
        /// Y5ANN8.
        /// </summary>
        public const string Y5ANN8 = "Y5ANN8";

        /// <summary>
        /// Y5UN.
        /// </summary>
        public const string Y5UN = "Y5UN";

        /// <summary>
        /// Y5JBCD.
        /// </summary>
        public const string Y5JBCD = "Y5JBCD";

        /// <summary>
        /// Y5JBST.
        /// </summary>
        public const string Y5JBST = "Y5JBST";

        /// <summary>
        /// Y5DT.
        /// </summary>
        public const string Y5DT = "Y5DT";

        /// <summary>
        /// Y5HMCO.
        /// </summary>
        public const string Y5HMCO = "Y5HMCO";

        /// <summary>
        /// Y5HMCU.
        /// </summary>
        public const string Y5HMCU = "Y5HMCU";

        /// <summary>
        /// Y5CKCN.
        /// </summary>
        public const string Y5CKCN = "Y5CKCN";

        /// <summary>
        /// Y5DPRI.
        /// </summary>
        public const string Y5DPRI = "Y5DPRI";

        /// <summary>
        /// Y5ARRR.
        /// </summary>
        public const string Y5ARRR = "Y5ARRR";

        /// <summary>
        /// Y5TRS.
        /// </summary>
        public const string Y5TRS = "Y5TRS";

        /// <summary>
        /// Y5DOCM.
        /// </summary>
        public const string Y5DOCM = "Y5DOCM";

        /// <summary>
        /// Y5ICS.
        /// </summary>
        public const string Y5ICS = "Y5ICS";

        /// <summary>
        /// Y5CKDT.
        /// </summary>
        public const string Y5CKDT = "Y5CKDT";

        /// <summary>
        /// Y5UPMJ.
        /// </summary>
        public const string Y5UPMJ = "Y5UPMJ";

        /// <summary>
        /// Y5UPMT.
        /// </summary>
        public const string Y5UPMT = "Y5UPMT";

        /// <summary>
        /// Y5JOBN.
        /// </summary>
        public const string Y5JOBN = "Y5JOBN";

        /// <summary>
        /// Y5USER.
        /// </summary>
        public const string Y5USER = "Y5USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07355";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y5PAYD", "Y5PAYD", JdeDataType.String, 20, true, true),
        new JdeField("Y5PID", "Y5PID", JdeDataType.String, 20, true, true),
        new JdeField("Y5AN8", "Y5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y5LIID", "Y5LIID", JdeDataType.Numeric, null, true, true),
        new JdeField("Y5ALPH", "Y5ALPH", JdeDataType.String, 80),
        new JdeField("Y5DL01", "Y5DL01", JdeDataType.String, 60),
        new JdeField("Y5DL02", "Y5DL02", JdeDataType.String, 60),
        new JdeField("Y5GPA", "Y5GPA", JdeDataType.Numeric),
        new JdeField("Y5G101", "Y5G101", JdeDataType.Numeric),
        new JdeField("Y5G102", "Y5G102", JdeDataType.Numeric),
        new JdeField("Y5G103", "Y5G103", JdeDataType.Numeric),
        new JdeField("Y5PHRW", "Y5PHRW", JdeDataType.Numeric),
        new JdeField("Y5ARRA", "Y5ARRA", JdeDataType.Numeric),
        new JdeField("Y5GPAY", "Y5GPAY", JdeDataType.Numeric),
        new JdeField("Y5USR", "Y5USR", JdeDataType.String, 36),
        new JdeField("Y5PDBA", "Y5PDBA", JdeDataType.Numeric),
        new JdeField("Y5DISO", "Y5DISO", JdeDataType.String, 2),
        new JdeField("Y5EKEY", "Y5EKEY", JdeDataType.String, 8),
        new JdeField("Y5ANN8", "Y5ANN8", JdeDataType.Numeric),
        new JdeField("Y5UN", "Y5UN", JdeDataType.String, 12),
        new JdeField("Y5JBCD", "Y5JBCD", JdeDataType.String, 12),
        new JdeField("Y5JBST", "Y5JBST", JdeDataType.String, 8),
        new JdeField("Y5DT", "Y5DT", JdeDataType.Numeric),
        new JdeField("Y5HMCO", "Y5HMCO", JdeDataType.String, 10),
        new JdeField("Y5HMCU", "Y5HMCU", JdeDataType.String, 24),
        new JdeField("Y5CKCN", "Y5CKCN", JdeDataType.Numeric),
        new JdeField("Y5DPRI", "Y5DPRI", JdeDataType.Numeric),
        new JdeField("Y5ARRR", "Y5ARRR", JdeDataType.String, 2),
        new JdeField("Y5TRS", "Y5TRS", JdeDataType.String, 6),
        new JdeField("Y5DOCM", "Y5DOCM", JdeDataType.Numeric),
        new JdeField("Y5ICS", "Y5ICS", JdeDataType.String, 2),
        new JdeField("Y5CKDT", "Y5CKDT", JdeDataType.Numeric),
        new JdeField("Y5UPMJ", "Y5UPMJ", JdeDataType.Numeric),
        new JdeField("Y5UPMT", "Y5UPMT", JdeDataType.Numeric),
        new JdeField("Y5JOBN", "Y5JOBN", JdeDataType.String, 20),
        new JdeField("Y5USER", "Y5USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07355_0", "Primary Key on Y5PAYD, Y5PID, Y5AN8, Y5LIID", new[] { "Y5PAYD", "Y5PID", "Y5AN8", "Y5LIID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07355_8", "Index on Y5PAYD, Y5AN8", new[] { "Y5PAYD", "Y5AN8" })
    };
}
