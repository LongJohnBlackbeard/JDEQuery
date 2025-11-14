using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77220 - .
/// </summary>
public class F77220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3YEID.
        /// </summary>
        public const string J3YEID = "J3YEID";

        /// <summary>
        /// J3TAXYR.
        /// </summary>
        public const string J3TAXYR = "J3TAXYR";

        /// <summary>
        /// J3AN8.
        /// </summary>
        public const string J3AN8 = "J3AN8";

        /// <summary>
        /// J3FORMSID.
        /// </summary>
        public const string J3FORMSID = "J3FORMSID";

        /// <summary>
        /// J3BOXN.
        /// </summary>
        public const string J3BOXN = "J3BOXN";

        /// <summary>
        /// J3HMCO.
        /// </summary>
        public const string J3HMCO = "J3HMCO";

        /// <summary>
        /// J3TAXX.
        /// </summary>
        public const string J3TAXX = "J3TAXX";

        /// <summary>
        /// J3TARA.
        /// </summary>
        public const string J3TARA = "J3TARA";

        /// <summary>
        /// J3CQ.
        /// </summary>
        public const string J3CQ = "J3CQ";

        /// <summary>
        /// J3CASEO.
        /// </summary>
        public const string J3CASEO = "J3CASEO";

        /// <summary>
        /// J3PDBA.
        /// </summary>
        public const string J3PDBA = "J3PDBA";

        /// <summary>
        /// J3AMNT.
        /// </summary>
        public const string J3AMNT = "J3AMNT";

        /// <summary>
        /// J3UPMJ.
        /// </summary>
        public const string J3UPMJ = "J3UPMJ";

        /// <summary>
        /// J3UPMT.
        /// </summary>
        public const string J3UPMT = "J3UPMT";

        /// <summary>
        /// J3PID.
        /// </summary>
        public const string J3PID = "J3PID";

        /// <summary>
        /// J3JOBN.
        /// </summary>
        public const string J3JOBN = "J3JOBN";

        /// <summary>
        /// J3USER.
        /// </summary>
        public const string J3USER = "J3USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3YEID", "J3YEID", JdeDataType.String, 20, true, true),
        new JdeField("J3TAXYR", "J3TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J3AN8", "J3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J3FORMSID", "J3FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J3BOXN", "J3BOXN", JdeDataType.String, 20, true, true),
        new JdeField("J3HMCO", "J3HMCO", JdeDataType.String, 10, true, true),
        new JdeField("J3TAXX", "J3TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J3TARA", "J3TARA", JdeDataType.String, 20, true, true),
        new JdeField("J3CQ", "J3CQ", JdeDataType.String, 120, true, true),
        new JdeField("J3CASEO", "J3CASEO", JdeDataType.String, 4, true, true),
        new JdeField("J3PDBA", "J3PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("J3AMNT", "J3AMNT", JdeDataType.Numeric),
        new JdeField("J3UPMJ", "J3UPMJ", JdeDataType.Numeric),
        new JdeField("J3UPMT", "J3UPMT", JdeDataType.Numeric),
        new JdeField("J3PID", "J3PID", JdeDataType.String, 20),
        new JdeField("J3JOBN", "J3JOBN", JdeDataType.String, 20),
        new JdeField("J3USER", "J3USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77220_0", "Primary Key on J3TAXYR, J3YEID, J3AN8, J3FORMSID, J3BOXN, J3HMCO, J3TAXX, J3TARA, J3CQ, J3CASEO, J3PDBA", new[] { "J3TAXYR", "J3YEID", "J3AN8", "J3FORMSID", "J3BOXN", "J3HMCO", "J3TAXX", "J3TARA", "J3CQ", "J3CASEO", "J3PDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77220_2", "Index on J3YEID, J3TAXYR, J3AN8, J3FORMSID, J3BOXN, J3CQ, J3CASEO, J3PDBA", new[] { "J3YEID", "J3TAXYR", "J3AN8", "J3FORMSID", "J3BOXN", "J3CQ", "J3CASEO", "J3PDBA" })
    };
}
