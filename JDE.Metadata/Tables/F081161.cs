using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F081161 - .
/// </summary>
public class F081161 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADACAD.
        /// </summary>
        public const string ADACAD = "ADACAD";

        /// <summary>
        /// ADACA#.
        /// </summary>
        public const string ADACA_ = "ADACA#";

        /// <summary>
        /// ADACAF.
        /// </summary>
        public const string ADACAF = "ADACAF";

        /// <summary>
        /// ADACES.
        /// </summary>
        public const string ADACES = "ADACES";

        /// <summary>
        /// ADESEDF.
        /// </summary>
        public const string ADESEDF = "ADESEDF";

        /// <summary>
        /// ADALE.
        /// </summary>
        public const string ADALE = "ADALE";

        /// <summary>
        /// ADACHW.
        /// </summary>
        public const string ADACHW = "ADACHW";

        /// <summary>
        /// ADACHM.
        /// </summary>
        public const string ADACHM = "ADACHM";

        /// <summary>
        /// ADACEF.
        /// </summary>
        public const string ADACEF = "ADACEF";

        /// <summary>
        /// ADACTH.
        /// </summary>
        public const string ADACTH = "ADACTH";

        /// <summary>
        /// ADACWK.
        /// </summary>
        public const string ADACWK = "ADACWK";

        /// <summary>
        /// ADACMO.
        /// </summary>
        public const string ADACMO = "ADACMO";

        /// <summary>
        /// ADALPH.
        /// </summary>
        public const string ADALPH = "ADALPH";

        /// <summary>
        /// ADGNNM.
        /// </summary>
        public const string ADGNNM = "ADGNNM";

        /// <summary>
        /// ADMDNM.
        /// </summary>
        public const string ADMDNM = "ADMDNM";

        /// <summary>
        /// ADSRNM.
        /// </summary>
        public const string ADSRNM = "ADSRNM";

        /// <summary>
        /// ADEST.
        /// </summary>
        public const string ADEST = "ADEST";

        /// <summary>
        /// ADPAST.
        /// </summary>
        public const string ADPAST = "ADPAST";

        /// <summary>
        /// ADSALY.
        /// </summary>
        public const string ADSALY = "ADSALY";

        /// <summary>
        /// ADDSI.
        /// </summary>
        public const string ADDSI = "ADDSI";

        /// <summary>
        /// ADDST.
        /// </summary>
        public const string ADDST = "ADDST";

        /// <summary>
        /// ADHSIRHD.
        /// </summary>
        public const string ADHSIRHD = "ADHSIRHD";

        /// <summary>
        /// ADHMCO.
        /// </summary>
        public const string ADHMCO = "ADHMCO";

        /// <summary>
        /// ADHMCU.
        /// </summary>
        public const string ADHMCU = "ADHMCU";

        /// <summary>
        /// ADJBCD.
        /// </summary>
        public const string ADJBCD = "ADJBCD";

        /// <summary>
        /// ADJBST.
        /// </summary>
        public const string ADJBST = "ADJBST";

        /// <summary>
        /// ADUN.
        /// </summary>
        public const string ADUN = "ADUN";

        /// <summary>
        /// ADDIVC.
        /// </summary>
        public const string ADDIVC = "ADDIVC";

        /// <summary>
        /// ADBENS.
        /// </summary>
        public const string ADBENS = "ADBENS";

        /// <summary>
        /// ADTARR.
        /// </summary>
        public const string ADTARR = "ADTARR";

        /// <summary>
        /// ADTARA.
        /// </summary>
        public const string ADTARA = "ADTARA";

        /// <summary>
        /// ADDCNF.
        /// </summary>
        public const string ADDCNF = "ADDCNF";

        /// <summary>
        /// ADDLS.
        /// </summary>
        public const string ADDLS = "ADDLS";

        /// <summary>
        /// ADTLS.
        /// </summary>
        public const string ADTLS = "ADTLS";

        /// <summary>
        /// ADRCOR.
        /// </summary>
        public const string ADRCOR = "ADRCOR";

        /// <summary>
        /// ADPACES.
        /// </summary>
        public const string ADPACES = "ADPACES";

        /// <summary>
        /// ADSPADUSD1.
        /// </summary>
        public const string ADSPADUSD1 = "ADSPADUSD1";

        /// <summary>
        /// ADSPADUSD2.
        /// </summary>
        public const string ADSPADUSD2 = "ADSPADUSD2";

        /// <summary>
        /// ADSPADUSD3.
        /// </summary>
        public const string ADSPADUSD3 = "ADSPADUSD3";

        /// <summary>
        /// ADSPADUSD4.
        /// </summary>
        public const string ADSPADUSD4 = "ADSPADUSD4";

        /// <summary>
        /// ADSPASUSD1.
        /// </summary>
        public const string ADSPASUSD1 = "ADSPASUSD1";

        /// <summary>
        /// ADSPASUSD2.
        /// </summary>
        public const string ADSPASUSD2 = "ADSPASUSD2";

        /// <summary>
        /// ADSPASUSD3.
        /// </summary>
        public const string ADSPASUSD3 = "ADSPASUSD3";

        /// <summary>
        /// ADSPASUSD4.
        /// </summary>
        public const string ADSPASUSD4 = "ADSPASUSD4";

        /// <summary>
        /// ADSPANUSD1.
        /// </summary>
        public const string ADSPANUSD1 = "ADSPANUSD1";

        /// <summary>
        /// ADSPANUSD2.
        /// </summary>
        public const string ADSPANUSD2 = "ADSPANUSD2";

        /// <summary>
        /// ADSPANUSD3.
        /// </summary>
        public const string ADSPANUSD3 = "ADSPANUSD3";

        /// <summary>
        /// ADSPANUSD4.
        /// </summary>
        public const string ADSPANUSD4 = "ADSPANUSD4";

        /// <summary>
        /// ADSPACUSD1.
        /// </summary>
        public const string ADSPACUSD1 = "ADSPACUSD1";

        /// <summary>
        /// ADSPACUSD2.
        /// </summary>
        public const string ADSPACUSD2 = "ADSPACUSD2";

        /// <summary>
        /// ADSPACUSD3.
        /// </summary>
        public const string ADSPACUSD3 = "ADSPACUSD3";

        /// <summary>
        /// ADSPACUSD4.
        /// </summary>
        public const string ADSPACUSD4 = "ADSPACUSD4";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F081161";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADACAD", "ADACAD", JdeDataType.String, 20, true, true),
        new JdeField("ADACA#", "ADACA#", JdeDataType.Numeric, null, true, true),
        new JdeField("ADACAF", "ADACAF", JdeDataType.String, 2),
        new JdeField("ADACES", "ADACES", JdeDataType.String, 4),
        new JdeField("ADESEDF", "ADESEDF", JdeDataType.Numeric),
        new JdeField("ADALE", "ADALE", JdeDataType.String, 20),
        new JdeField("ADACHW", "ADACHW", JdeDataType.Numeric),
        new JdeField("ADACHM", "ADACHM", JdeDataType.Numeric),
        new JdeField("ADACEF", "ADACEF", JdeDataType.String, 2),
        new JdeField("ADACTH", "ADACTH", JdeDataType.Numeric),
        new JdeField("ADACWK", "ADACWK", JdeDataType.Numeric),
        new JdeField("ADACMO", "ADACMO", JdeDataType.Numeric),
        new JdeField("ADALPH", "ADALPH", JdeDataType.String, 80),
        new JdeField("ADGNNM", "ADGNNM", JdeDataType.String, 50),
        new JdeField("ADMDNM", "ADMDNM", JdeDataType.String, 50),
        new JdeField("ADSRNM", "ADSRNM", JdeDataType.String, 50),
        new JdeField("ADEST", "ADEST", JdeDataType.String, 2),
        new JdeField("ADPAST", "ADPAST", JdeDataType.String, 2),
        new JdeField("ADSALY", "ADSALY", JdeDataType.String, 2),
        new JdeField("ADDSI", "ADDSI", JdeDataType.Numeric),
        new JdeField("ADDST", "ADDST", JdeDataType.Numeric),
        new JdeField("ADHSIRHD", "ADHSIRHD", JdeDataType.Numeric),
        new JdeField("ADHMCO", "ADHMCO", JdeDataType.String, 10),
        new JdeField("ADHMCU", "ADHMCU", JdeDataType.String, 24),
        new JdeField("ADJBCD", "ADJBCD", JdeDataType.String, 12),
        new JdeField("ADJBST", "ADJBST", JdeDataType.String, 8),
        new JdeField("ADUN", "ADUN", JdeDataType.String, 12),
        new JdeField("ADDIVC", "ADDIVC", JdeDataType.String, 12),
        new JdeField("ADBENS", "ADBENS", JdeDataType.String, 2),
        new JdeField("ADTARR", "ADTARR", JdeDataType.String, 20),
        new JdeField("ADTARA", "ADTARA", JdeDataType.String, 20),
        new JdeField("ADDCNF", "ADDCNF", JdeDataType.String, 2),
        new JdeField("ADDLS", "ADDLS", JdeDataType.Numeric),
        new JdeField("ADTLS", "ADTLS", JdeDataType.Numeric),
        new JdeField("ADRCOR", "ADRCOR", JdeDataType.String, 2),
        new JdeField("ADPACES", "ADPACES", JdeDataType.String, 4),
        new JdeField("ADSPADUSD1", "ADSPADUSD1", JdeDataType.Numeric),
        new JdeField("ADSPADUSD2", "ADSPADUSD2", JdeDataType.Numeric),
        new JdeField("ADSPADUSD3", "ADSPADUSD3", JdeDataType.Numeric),
        new JdeField("ADSPADUSD4", "ADSPADUSD4", JdeDataType.Numeric),
        new JdeField("ADSPASUSD1", "ADSPASUSD1", JdeDataType.String, 60),
        new JdeField("ADSPASUSD2", "ADSPASUSD2", JdeDataType.String, 60),
        new JdeField("ADSPASUSD3", "ADSPASUSD3", JdeDataType.String, 60),
        new JdeField("ADSPASUSD4", "ADSPASUSD4", JdeDataType.String, 60),
        new JdeField("ADSPANUSD1", "ADSPANUSD1", JdeDataType.Numeric),
        new JdeField("ADSPANUSD2", "ADSPANUSD2", JdeDataType.Numeric),
        new JdeField("ADSPANUSD3", "ADSPANUSD3", JdeDataType.Numeric),
        new JdeField("ADSPANUSD4", "ADSPANUSD4", JdeDataType.Numeric),
        new JdeField("ADSPACUSD1", "ADSPACUSD1", JdeDataType.String, 2),
        new JdeField("ADSPACUSD2", "ADSPACUSD2", JdeDataType.String, 2),
        new JdeField("ADSPACUSD3", "ADSPACUSD3", JdeDataType.String, 2),
        new JdeField("ADSPACUSD4", "ADSPACUSD4", JdeDataType.String, 2),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F081161_0", "Primary Key on ADAN8, ADACAD, ADACA#", new[] { "ADAN8", "ADACAD", "ADACA#" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F081161_2", "Index on ADAN8, ADACAF", new[] { "ADAN8", "ADACAF" }),
        new JdeIndex("F081161_3", "Index on ADACAD, ADACA#", new[] { "ADACAD", "ADACA#" }),
        new JdeIndex("F081161_4", "Index on ADACAD, ADACAF", new[] { "ADACAD", "ADACAF" }),
        new JdeIndex("F081161_5", "Index on ADAN8, SYS_NC00059$, SYS_NC00060$", new[] { "ADAN8", "SYS_NC00059$", "SYS_NC00060$" })
    };
}
