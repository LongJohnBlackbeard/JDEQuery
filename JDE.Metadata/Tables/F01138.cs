using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01138 - .
/// </summary>
public class F01138 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSPRMSNTYP.
        /// </summary>
        public const string DSPRMSNTYP = "DSPRMSNTYP";

        /// <summary>
        /// DSPRMSNLST.
        /// </summary>
        public const string DSPRMSNLST = "DSPRMSNLST";

        /// <summary>
        /// DSAT1.
        /// </summary>
        public const string DSAT1 = "DSAT1";

        /// <summary>
        /// DSSECTAX.
        /// </summary>
        public const string DSSECTAX = "DSSECTAX";

        /// <summary>
        /// DSSECTX2.
        /// </summary>
        public const string DSSECTX2 = "DSSECTX2";

        /// <summary>
        /// DSSECADDR.
        /// </summary>
        public const string DSSECADDR = "DSSECADDR";

        /// <summary>
        /// DSSECPHONE.
        /// </summary>
        public const string DSSECPHONE = "DSSECPHONE";

        /// <summary>
        /// DSSECEMAL.
        /// </summary>
        public const string DSSECEMAL = "DSSECEMAL";

        /// <summary>
        /// DSSECDOB.
        /// </summary>
        public const string DSSECDOB = "DSSECDOB";

        /// <summary>
        /// DSSECGEND.
        /// </summary>
        public const string DSSECGEND = "DSSECGEND";

        /// <summary>
        /// DSSECMATH1.
        /// </summary>
        public const string DSSECMATH1 = "DSSECMATH1";

        /// <summary>
        /// DSSECSZ1.
        /// </summary>
        public const string DSSECSZ1 = "DSSECSZ1";

        /// <summary>
        /// DSSECSZ2.
        /// </summary>
        public const string DSSECSZ2 = "DSSECSZ2";

        /// <summary>
        /// DSSECSZ3.
        /// </summary>
        public const string DSSECSZ3 = "DSSECSZ3";

        /// <summary>
        /// DSSECSZ4.
        /// </summary>
        public const string DSSECSZ4 = "DSSECSZ4";

        /// <summary>
        /// DSSECSZ5.
        /// </summary>
        public const string DSSECSZ5 = "DSSECSZ5";

        /// <summary>
        /// DSSECCHAR.
        /// </summary>
        public const string DSSECCHAR = "DSSECCHAR";

        /// <summary>
        /// DSSECDATE.
        /// </summary>
        public const string DSSECDATE = "DSSECDATE";

        /// <summary>
        /// DSSECUDMN1.
        /// </summary>
        public const string DSSECUDMN1 = "DSSECUDMN1";

        /// <summary>
        /// DSSECUDSZ1.
        /// </summary>
        public const string DSSECUDSZ1 = "DSSECUDSZ1";

        /// <summary>
        /// DSSECUDSZ2.
        /// </summary>
        public const string DSSECUDSZ2 = "DSSECUDSZ2";

        /// <summary>
        /// DSSECUDSZ3.
        /// </summary>
        public const string DSSECUDSZ3 = "DSSECUDSZ3";

        /// <summary>
        /// DSSECUDSZ4.
        /// </summary>
        public const string DSSECUDSZ4 = "DSSECUDSZ4";

        /// <summary>
        /// DSSECUDSZ5.
        /// </summary>
        public const string DSSECUDSZ5 = "DSSECUDSZ5";

        /// <summary>
        /// DSSECUDC.
        /// </summary>
        public const string DSSECUDC = "DSSECUDC";

        /// <summary>
        /// DSSECUDD.
        /// </summary>
        public const string DSSECUDD = "DSSECUDD";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSUPMT.
        /// </summary>
        public const string DSUPMT = "DSUPMT";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F01138";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSPRMSNTYP", "DSPRMSNTYP", JdeDataType.String, 8, true, true),
        new JdeField("DSPRMSNLST", "DSPRMSNLST", JdeDataType.String, 30, true, true),
        new JdeField("DSAT1", "DSAT1", JdeDataType.String, 6, true, true),
        new JdeField("DSSECTAX", "DSSECTAX", JdeDataType.String, 2),
        new JdeField("DSSECTX2", "DSSECTX2", JdeDataType.String, 2),
        new JdeField("DSSECADDR", "DSSECADDR", JdeDataType.String, 2),
        new JdeField("DSSECPHONE", "DSSECPHONE", JdeDataType.String, 2),
        new JdeField("DSSECEMAL", "DSSECEMAL", JdeDataType.String, 2),
        new JdeField("DSSECDOB", "DSSECDOB", JdeDataType.String, 2),
        new JdeField("DSSECGEND", "DSSECGEND", JdeDataType.String, 2),
        new JdeField("DSSECMATH1", "DSSECMATH1", JdeDataType.String, 2),
        new JdeField("DSSECSZ1", "DSSECSZ1", JdeDataType.String, 2),
        new JdeField("DSSECSZ2", "DSSECSZ2", JdeDataType.String, 2),
        new JdeField("DSSECSZ3", "DSSECSZ3", JdeDataType.String, 2),
        new JdeField("DSSECSZ4", "DSSECSZ4", JdeDataType.String, 2),
        new JdeField("DSSECSZ5", "DSSECSZ5", JdeDataType.String, 2),
        new JdeField("DSSECCHAR", "DSSECCHAR", JdeDataType.String, 2),
        new JdeField("DSSECDATE", "DSSECDATE", JdeDataType.String, 2),
        new JdeField("DSSECUDMN1", "DSSECUDMN1", JdeDataType.String, 2),
        new JdeField("DSSECUDSZ1", "DSSECUDSZ1", JdeDataType.String, 2),
        new JdeField("DSSECUDSZ2", "DSSECUDSZ2", JdeDataType.String, 2),
        new JdeField("DSSECUDSZ3", "DSSECUDSZ3", JdeDataType.String, 2),
        new JdeField("DSSECUDSZ4", "DSSECUDSZ4", JdeDataType.String, 2),
        new JdeField("DSSECUDSZ5", "DSSECUDSZ5", JdeDataType.String, 2),
        new JdeField("DSSECUDC", "DSSECUDC", JdeDataType.String, 2),
        new JdeField("DSSECUDD", "DSSECUDD", JdeDataType.String, 2),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSUPMT", "DSUPMT", JdeDataType.Numeric),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01138_0", "Primary Key on DSPRMSNTYP, DSPRMSNLST, DSAT1", new[] { "DSPRMSNTYP", "DSPRMSNLST", "DSAT1" }, isUnique: true, isPrimaryKey: true)
    };
}
