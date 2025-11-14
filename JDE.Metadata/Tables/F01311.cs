using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01311 - .
/// </summary>
public class F01311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCINDID.
        /// </summary>
        public const string CCINDID = "CCINDID";

        /// <summary>
        /// CCINDIDTY.
        /// </summary>
        public const string CCINDIDTY = "CCINDIDTY";

        /// <summary>
        /// CCCALTY.
        /// </summary>
        public const string CCCALTY = "CCCALTY";

        /// <summary>
        /// CCCALNM.
        /// </summary>
        public const string CCCALNM = "CCCALNM";

        /// <summary>
        /// CCCALPRV.
        /// </summary>
        public const string CCCALPRV = "CCCALPRV";

        /// <summary>
        /// CCDFVM.
        /// </summary>
        public const string CCDFVM = "CCDFVM";

        /// <summary>
        /// CCWDS.
        /// </summary>
        public const string CCWDS = "CCWDS";

        /// <summary>
        /// CCWDE.
        /// </summary>
        public const string CCWDE = "CCWDE";

        /// <summary>
        /// CCWWS.
        /// </summary>
        public const string CCWWS = "CCWWS";

        /// <summary>
        /// CCWWE.
        /// </summary>
        public const string CCWWE = "CCWWE";

        /// <summary>
        /// CCDVIEW.
        /// </summary>
        public const string CCDVIEW = "CCDVIEW";

        /// <summary>
        /// CCWVIEW.
        /// </summary>
        public const string CCWVIEW = "CCWVIEW";

        /// <summary>
        /// CCMVIEW.
        /// </summary>
        public const string CCMVIEW = "CCMVIEW";

        /// <summary>
        /// CCCLNCD1.
        /// </summary>
        public const string CCCLNCD1 = "CCCLNCD1";

        /// <summary>
        /// CCCLNCD2.
        /// </summary>
        public const string CCCLNCD2 = "CCCLNCD2";

        /// <summary>
        /// CCCLNCD3.
        /// </summary>
        public const string CCCLNCD3 = "CCCLNCD3";

        /// <summary>
        /// CCCLNCD4.
        /// </summary>
        public const string CCCLNCD4 = "CCCLNCD4";

        /// <summary>
        /// CCCLNCD5.
        /// </summary>
        public const string CCCLNCD5 = "CCCLNCD5";

        /// <summary>
        /// CCURCH.
        /// </summary>
        public const string CCURCH = "CCURCH";

        /// <summary>
        /// CCURNUM.
        /// </summary>
        public const string CCURNUM = "CCURNUM";

        /// <summary>
        /// CCURTIME.
        /// </summary>
        public const string CCURTIME = "CCURTIME";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCUDTU.
        /// </summary>
        public const string CCUDTU = "CCUDTU";

        /// <summary>
        /// CCIDAN8.
        /// </summary>
        public const string CCIDAN8 = "CCIDAN8";

        /// <summary>
        /// CCENTDBY.
        /// </summary>
        public const string CCENTDBY = "CCENTDBY";

        /// <summary>
        /// CCEDATE.
        /// </summary>
        public const string CCEDATE = "CCEDATE";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F01311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCINDID", "CCINDID", JdeDataType.String, 32, true, true),
        new JdeField("CCINDIDTY", "CCINDIDTY", JdeDataType.String, 100, true, true),
        new JdeField("CCCALTY", "CCCALTY", JdeDataType.String, 100, true, true),
        new JdeField("CCCALNM", "CCCALNM", JdeDataType.String, 100),
        new JdeField("CCCALPRV", "CCCALPRV", JdeDataType.String, 2),
        new JdeField("CCDFVM", "CCDFVM", JdeDataType.String, 20),
        new JdeField("CCWDS", "CCWDS", JdeDataType.String, 10),
        new JdeField("CCWDE", "CCWDE", JdeDataType.String, 10),
        new JdeField("CCWWS", "CCWWS", JdeDataType.String, 18),
        new JdeField("CCWWE", "CCWWE", JdeDataType.String, 18),
        new JdeField("CCDVIEW", "CCDVIEW", JdeDataType.String, 2),
        new JdeField("CCWVIEW", "CCWVIEW", JdeDataType.String, 2),
        new JdeField("CCMVIEW", "CCMVIEW", JdeDataType.String, 2),
        new JdeField("CCCLNCD1", "CCCLNCD1", JdeDataType.String, 6),
        new JdeField("CCCLNCD2", "CCCLNCD2", JdeDataType.String, 6),
        new JdeField("CCCLNCD3", "CCCLNCD3", JdeDataType.String, 6),
        new JdeField("CCCLNCD4", "CCCLNCD4", JdeDataType.String, 6),
        new JdeField("CCCLNCD5", "CCCLNCD5", JdeDataType.String, 6),
        new JdeField("CCURCH", "CCURCH", JdeDataType.String, 100),
        new JdeField("CCURNUM", "CCURNUM", JdeDataType.Numeric),
        new JdeField("CCURTIME", "CCURTIME", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCUDTU", "CCUDTU", JdeDataType.Date),
        new JdeField("CCIDAN8", "CCIDAN8", JdeDataType.Numeric),
        new JdeField("CCENTDBY", "CCENTDBY", JdeDataType.Numeric),
        new JdeField("CCEDATE", "CCEDATE", JdeDataType.Date),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01311_0", "Primary Key on CCINDID, CCINDIDTY, CCCALTY", new[] { "CCINDID", "CCINDIDTY", "CCCALTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01311_2", "Index on CCIDAN8", new[] { "CCIDAN8" })
    };
}
