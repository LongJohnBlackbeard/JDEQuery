using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09522 - .
/// </summary>
public class F09522 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDBSDATE.
        /// </summary>
        public const string FDBSDATE = "FDBSDATE";

        /// <summary>
        /// FDCSHTYP.
        /// </summary>
        public const string FDCSHTYP = "FDCSHTYP";

        /// <summary>
        /// FDBNKAID.
        /// </summary>
        public const string FDBNKAID = "FDBNKAID";

        /// <summary>
        /// FDDDJ.
        /// </summary>
        public const string FDDDJ = "FDDDJ";

        /// <summary>
        /// FDBCRC.
        /// </summary>
        public const string FDBCRC = "FDBCRC";

        /// <summary>
        /// FDAA.
        /// </summary>
        public const string FDAA = "FDAA";

        /// <summary>
        /// FDNDCRCD.
        /// </summary>
        public const string FDNDCRCD = "FDNDCRCD";

        /// <summary>
        /// FDNDAA.
        /// </summary>
        public const string FDNDAA = "FDNDAA";

        /// <summary>
        /// FDSRCSYS.
        /// </summary>
        public const string FDSRCSYS = "FDSRCSYS";

        /// <summary>
        /// FDCO.
        /// </summary>
        public const string FDCO = "FDCO";

        /// <summary>
        /// FDMCU.
        /// </summary>
        public const string FDMCU = "FDMCU";

        /// <summary>
        /// FDOBJ.
        /// </summary>
        public const string FDOBJ = "FDOBJ";

        /// <summary>
        /// FDSUB.
        /// </summary>
        public const string FDSUB = "FDSUB";

        /// <summary>
        /// FDCFAMT3.
        /// </summary>
        public const string FDCFAMT3 = "FDCFAMT3";

        /// <summary>
        /// FDCFAMT4.
        /// </summary>
        public const string FDCFAMT4 = "FDCFAMT4";

        /// <summary>
        /// FDCFAMT5.
        /// </summary>
        public const string FDCFAMT5 = "FDCFAMT5";

        /// <summary>
        /// FDCFAMT6.
        /// </summary>
        public const string FDCFAMT6 = "FDCFAMT6";

        /// <summary>
        /// FDCFAMT7.
        /// </summary>
        public const string FDCFAMT7 = "FDCFAMT7";

        /// <summary>
        /// FDCFAMT8.
        /// </summary>
        public const string FDCFAMT8 = "FDCFAMT8";

        /// <summary>
        /// FDCFAMT9.
        /// </summary>
        public const string FDCFAMT9 = "FDCFAMT9";

        /// <summary>
        /// FDCFAMT10.
        /// </summary>
        public const string FDCFAMT10 = "FDCFAMT10";

        /// <summary>
        /// FDCFDTE2.
        /// </summary>
        public const string FDCFDTE2 = "FDCFDTE2";

        /// <summary>
        /// FDCFDSC2.
        /// </summary>
        public const string FDCFDSC2 = "FDCFDSC2";

        /// <summary>
        /// FDCFFLG1.
        /// </summary>
        public const string FDCFFLG1 = "FDCFFLG1";

        /// <summary>
        /// FDCFNO3.
        /// </summary>
        public const string FDCFNO3 = "FDCFNO3";

        /// <summary>
        /// FDCFSTR3.
        /// </summary>
        public const string FDCFSTR3 = "FDCFSTR3";

        /// <summary>
        /// FDCFSTR4.
        /// </summary>
        public const string FDCFSTR4 = "FDCFSTR4";

        /// <summary>
        /// FDCFSTR6.
        /// </summary>
        public const string FDCFSTR6 = "FDCFSTR6";

        /// <summary>
        /// FDCFSTR7.
        /// </summary>
        public const string FDCFSTR7 = "FDCFSTR7";

        /// <summary>
        /// FDCFSTR8.
        /// </summary>
        public const string FDCFSTR8 = "FDCFSTR8";

        /// <summary>
        /// FDRFSTAT.
        /// </summary>
        public const string FDRFSTAT = "FDRFSTAT";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDUPMT.
        /// </summary>
        public const string FDUPMT = "FDUPMT";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09522";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDBSDATE", "FDBSDATE", JdeDataType.Numeric, null, true, true),
        new JdeField("FDCSHTYP", "FDCSHTYP", JdeDataType.String, 20, true, true),
        new JdeField("FDBNKAID", "FDBNKAID", JdeDataType.String, 16, true, true),
        new JdeField("FDDDJ", "FDDDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FDBCRC", "FDBCRC", JdeDataType.String, 6, true, true),
        new JdeField("FDAA", "FDAA", JdeDataType.Numeric),
        new JdeField("FDNDCRCD", "FDNDCRCD", JdeDataType.String, 6),
        new JdeField("FDNDAA", "FDNDAA", JdeDataType.Numeric),
        new JdeField("FDSRCSYS", "FDSRCSYS", JdeDataType.String, 8),
        new JdeField("FDCO", "FDCO", JdeDataType.String, 10),
        new JdeField("FDMCU", "FDMCU", JdeDataType.String, 24),
        new JdeField("FDOBJ", "FDOBJ", JdeDataType.String, 12),
        new JdeField("FDSUB", "FDSUB", JdeDataType.String, 16),
        new JdeField("FDCFAMT3", "FDCFAMT3", JdeDataType.Numeric),
        new JdeField("FDCFAMT4", "FDCFAMT4", JdeDataType.Numeric),
        new JdeField("FDCFAMT5", "FDCFAMT5", JdeDataType.Numeric),
        new JdeField("FDCFAMT6", "FDCFAMT6", JdeDataType.Numeric),
        new JdeField("FDCFAMT7", "FDCFAMT7", JdeDataType.Numeric),
        new JdeField("FDCFAMT8", "FDCFAMT8", JdeDataType.Numeric),
        new JdeField("FDCFAMT9", "FDCFAMT9", JdeDataType.Numeric),
        new JdeField("FDCFAMT10", "FDCFAMT10", JdeDataType.Numeric),
        new JdeField("FDCFDTE2", "FDCFDTE2", JdeDataType.Numeric),
        new JdeField("FDCFDSC2", "FDCFDSC2", JdeDataType.String, 58),
        new JdeField("FDCFFLG1", "FDCFFLG1", JdeDataType.String, 2),
        new JdeField("FDCFNO3", "FDCFNO3", JdeDataType.Numeric),
        new JdeField("FDCFSTR3", "FDCFSTR3", JdeDataType.String, 6),
        new JdeField("FDCFSTR4", "FDCFSTR4", JdeDataType.String, 16),
        new JdeField("FDCFSTR6", "FDCFSTR6", JdeDataType.String, 10),
        new JdeField("FDCFSTR7", "FDCFSTR7", JdeDataType.String, 24),
        new JdeField("FDCFSTR8", "FDCFSTR8", JdeDataType.String, 12),
        new JdeField("FDRFSTAT", "FDRFSTAT", JdeDataType.String, 2),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDUPMT", "FDUPMT", JdeDataType.Numeric),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09522_0", "Primary Key on FDBSDATE, FDCSHTYP, FDBNKAID, FDBCRC, FDDDJ", new[] { "FDBSDATE", "FDCSHTYP", "FDBNKAID", "FDBCRC", "FDDDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09522_2", "Index on SYS_NC00037$, FDRFSTAT", new[] { "SYS_NC00037$", "FDRFSTAT" }),
        new JdeIndex("F09522_3", "Index on FDBSDATE, FDSRCSYS, FDBNKAID", new[] { "FDBSDATE", "FDSRCSYS", "FDBNKAID" }),
        new JdeIndex("F09522_4", "Index on FDBSDATE, FDRFSTAT", new[] { "FDBSDATE", "FDRFSTAT" }),
        new JdeIndex("F09522_5", "Index on FDBSDATE, FDCSHTYP, FDBNKAID, FDDDJ, FDBCRC", new[] { "FDBSDATE", "FDCSHTYP", "FDBNKAID", "FDDDJ", "FDBCRC" }),
        new JdeIndex("F09522_6", "Index on FDBSDATE, FDCSHTYP, FDMCU, FDOBJ, FDSUB", new[] { "FDBSDATE", "FDCSHTYP", "FDMCU", "FDOBJ", "FDSUB" })
    };
}
