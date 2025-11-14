using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4107 - .
/// </summary>
public class F4107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IFITM.
        /// </summary>
        public const string IFITM = "IFITM";

        /// <summary>
        /// IFOSEQ.
        /// </summary>
        public const string IFOSEQ = "IFOSEQ";

        /// <summary>
        /// IFITMCAT.
        /// </summary>
        public const string IFITMCAT = "IFITMCAT";

        /// <summary>
        /// IFSDSC1.
        /// </summary>
        public const string IFSDSC1 = "IFSDSC1";

        /// <summary>
        /// IFEXVAR0.
        /// </summary>
        public const string IFEXVAR0 = "IFEXVAR0";

        /// <summary>
        /// IFEXVAR1.
        /// </summary>
        public const string IFEXVAR1 = "IFEXVAR1";

        /// <summary>
        /// IFEXVAR4.
        /// </summary>
        public const string IFEXVAR4 = "IFEXVAR4";

        /// <summary>
        /// IFEXVAR5.
        /// </summary>
        public const string IFEXVAR5 = "IFEXVAR5";

        /// <summary>
        /// IFEXVAR6.
        /// </summary>
        public const string IFEXVAR6 = "IFEXVAR6";

        /// <summary>
        /// IFEXVAR7.
        /// </summary>
        public const string IFEXVAR7 = "IFEXVAR7";

        /// <summary>
        /// IFEXVAR12.
        /// </summary>
        public const string IFEXVAR12 = "IFEXVAR12";

        /// <summary>
        /// IFEXVAR13.
        /// </summary>
        public const string IFEXVAR13 = "IFEXVAR13";

        /// <summary>
        /// IFEXNM0.
        /// </summary>
        public const string IFEXNM0 = "IFEXNM0";

        /// <summary>
        /// IFEXNM1.
        /// </summary>
        public const string IFEXNM1 = "IFEXNM1";

        /// <summary>
        /// IFEXNM2.
        /// </summary>
        public const string IFEXNM2 = "IFEXNM2";

        /// <summary>
        /// IFEXNMP0.
        /// </summary>
        public const string IFEXNMP0 = "IFEXNMP0";

        /// <summary>
        /// IFEXNMP1.
        /// </summary>
        public const string IFEXNMP1 = "IFEXNMP1";

        /// <summary>
        /// IFEXNMP2.
        /// </summary>
        public const string IFEXNMP2 = "IFEXNMP2";

        /// <summary>
        /// IFEXDT0.
        /// </summary>
        public const string IFEXDT0 = "IFEXDT0";

        /// <summary>
        /// IFEXDT1.
        /// </summary>
        public const string IFEXDT1 = "IFEXDT1";

        /// <summary>
        /// IFEXDT2.
        /// </summary>
        public const string IFEXDT2 = "IFEXDT2";

        /// <summary>
        /// IFSTSUDT.
        /// </summary>
        public const string IFSTSUDT = "IFSTSUDT";

        /// <summary>
        /// IFACTIND.
        /// </summary>
        public const string IFACTIND = "IFACTIND";

        /// <summary>
        /// IFEDATE.
        /// </summary>
        public const string IFEDATE = "IFEDATE";

        /// <summary>
        /// IFENTDBY.
        /// </summary>
        public const string IFENTDBY = "IFENTDBY";

        /// <summary>
        /// IFUDTTM.
        /// </summary>
        public const string IFUDTTM = "IFUDTTM";

        /// <summary>
        /// IFUSER.
        /// </summary>
        public const string IFUSER = "IFUSER";

        /// <summary>
        /// IFJOBN.
        /// </summary>
        public const string IFJOBN = "IFJOBN";

        /// <summary>
        /// IFMKEY.
        /// </summary>
        public const string IFMKEY = "IFMKEY";

        /// <summary>
        /// IFPID.
        /// </summary>
        public const string IFPID = "IFPID";

        /// <summary>
        /// IFVID.
        /// </summary>
        public const string IFVID = "IFVID";
    }

    /// <inheritdoc />
    public override string TableName => "F4107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IFITM", "IFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IFOSEQ", "IFOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IFITMCAT", "IFITMCAT", JdeDataType.String, 10),
        new JdeField("IFSDSC1", "IFSDSC1", JdeDataType.String, 100),
        new JdeField("IFEXVAR0", "IFEXVAR0", JdeDataType.String, 510),
        new JdeField("IFEXVAR1", "IFEXVAR1", JdeDataType.String, 510),
        new JdeField("IFEXVAR4", "IFEXVAR4", JdeDataType.String, 100),
        new JdeField("IFEXVAR5", "IFEXVAR5", JdeDataType.String, 100),
        new JdeField("IFEXVAR6", "IFEXVAR6", JdeDataType.String, 100),
        new JdeField("IFEXVAR7", "IFEXVAR7", JdeDataType.String, 100),
        new JdeField("IFEXVAR12", "IFEXVAR12", JdeDataType.String, 50),
        new JdeField("IFEXVAR13", "IFEXVAR13", JdeDataType.String, 50),
        new JdeField("IFEXNM0", "IFEXNM0", JdeDataType.Numeric),
        new JdeField("IFEXNM1", "IFEXNM1", JdeDataType.Numeric),
        new JdeField("IFEXNM2", "IFEXNM2", JdeDataType.Numeric),
        new JdeField("IFEXNMP0", "IFEXNMP0", JdeDataType.Numeric),
        new JdeField("IFEXNMP1", "IFEXNMP1", JdeDataType.Numeric),
        new JdeField("IFEXNMP2", "IFEXNMP2", JdeDataType.Numeric),
        new JdeField("IFEXDT0", "IFEXDT0", JdeDataType.Date),
        new JdeField("IFEXDT1", "IFEXDT1", JdeDataType.Date),
        new JdeField("IFEXDT2", "IFEXDT2", JdeDataType.Date),
        new JdeField("IFSTSUDT", "IFSTSUDT", JdeDataType.Date),
        new JdeField("IFACTIND", "IFACTIND", JdeDataType.String, 2),
        new JdeField("IFEDATE", "IFEDATE", JdeDataType.Date),
        new JdeField("IFENTDBY", "IFENTDBY", JdeDataType.Numeric),
        new JdeField("IFUDTTM", "IFUDTTM", JdeDataType.Date),
        new JdeField("IFUSER", "IFUSER", JdeDataType.String, 20),
        new JdeField("IFJOBN", "IFJOBN", JdeDataType.String, 20),
        new JdeField("IFMKEY", "IFMKEY", JdeDataType.String, 30),
        new JdeField("IFPID", "IFPID", JdeDataType.String, 20),
        new JdeField("IFVID", "IFVID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4107_0", "Primary Key on IFITM, IFOSEQ", new[] { "IFITM", "IFOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
