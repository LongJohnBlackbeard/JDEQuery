using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B473 - .
/// </summary>
public class F76B473 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSBDFLAY.
        /// </summary>
        public const string DSBDFLAY = "DSBDFLAY";

        /// <summary>
        /// DSDRIN.
        /// </summary>
        public const string DSDRIN = "DSDRIN";

        /// <summary>
        /// DSEDTY.
        /// </summary>
        public const string DSEDTY = "DSEDTY";

        /// <summary>
        /// DSLIID.
        /// </summary>
        public const string DSLIID = "DSLIID";

        /// <summary>
        /// DSBDFATR.
        /// </summary>
        public const string DSBDFATR = "DSBDFATR";

        /// <summary>
        /// DSBDFBEP.
        /// </summary>
        public const string DSBDFBEP = "DSBDFBEP";

        /// <summary>
        /// DSBDFENP.
        /// </summary>
        public const string DSBDFENP = "DSBDFENP";

        /// <summary>
        /// DSDSCA.
        /// </summary>
        public const string DSDSCA = "DSDSCA";

        /// <summary>
        /// DSDFTV.
        /// </summary>
        public const string DSDFTV = "DSDFTV";

        /// <summary>
        /// DSOWTP.
        /// </summary>
        public const string DSOWTP = "DSOWTP";

        /// <summary>
        /// DSDTAD.
        /// </summary>
        public const string DSDTAD = "DSDTAD";

        /// <summary>
        /// DSDECF.
        /// </summary>
        public const string DSDECF = "DSDECF";

        /// <summary>
        /// DSJDEALGNL.
        /// </summary>
        public const string DSJDEALGNL = "DSJDEALGNL";

        /// <summary>
        /// DSQ1.
        /// </summary>
        public const string DSQ1 = "DSQ1";

        /// <summary>
        /// DSFRMT.
        /// </summary>
        public const string DSFRMT = "DSFRMT";

        /// <summary>
        /// DSDSEP.
        /// </summary>
        public const string DSDSEP = "DSDSEP";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSUPMT.
        /// </summary>
        public const string DSUPMT = "DSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B473";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSBDFLAY", "DSBDFLAY", JdeDataType.String, 20, true, true),
        new JdeField("DSDRIN", "DSDRIN", JdeDataType.String, 2, true, true),
        new JdeField("DSEDTY", "DSEDTY", JdeDataType.String, 2, true, true),
        new JdeField("DSLIID", "DSLIID", JdeDataType.Numeric, null, true, true),
        new JdeField("DSBDFATR", "DSBDFATR", JdeDataType.String, 10),
        new JdeField("DSBDFBEP", "DSBDFBEP", JdeDataType.Numeric, null, true, true),
        new JdeField("DSBDFENP", "DSBDFENP", JdeDataType.Numeric),
        new JdeField("DSDSCA", "DSDSCA", JdeDataType.String, 80),
        new JdeField("DSDFTV", "DSDFTV", JdeDataType.String, 60),
        new JdeField("DSOWTP", "DSOWTP", JdeDataType.String, 4),
        new JdeField("DSDTAD", "DSDTAD", JdeDataType.Numeric),
        new JdeField("DSDECF", "DSDECF", JdeDataType.String, 2),
        new JdeField("DSJDEALGNL", "DSJDEALGNL", JdeDataType.String, 2),
        new JdeField("DSQ1", "DSQ1", JdeDataType.String, 2),
        new JdeField("DSFRMT", "DSFRMT", JdeDataType.String, 6),
        new JdeField("DSDSEP", "DSDSEP", JdeDataType.String, 2),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSUPMT", "DSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B473_0", "Primary Key on DSBDFLAY, DSDRIN, DSEDTY, DSLIID, DSBDFBEP", new[] { "DSBDFLAY", "DSDRIN", "DSEDTY", "DSLIID", "DSBDFBEP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B473_2", "Index on DSBDFLAY, DSDRIN, DSEDTY, DSLIID, DSBDFATR", new[] { "DSBDFLAY", "DSDRIN", "DSEDTY", "DSLIID", "DSBDFATR" }),
        new JdeIndex("F76B473_3", "Index on DSBDFLAY, DSDRIN, DSEDTY, DSBDFATR", new[] { "DSBDFLAY", "DSDRIN", "DSEDTY", "DSBDFATR" })
    };
}
