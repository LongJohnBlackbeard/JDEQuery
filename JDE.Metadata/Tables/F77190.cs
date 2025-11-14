using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77190 - .
/// </summary>
public class F77190 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J2TAXYR.
        /// </summary>
        public const string J2TAXYR = "J2TAXYR";

        /// <summary>
        /// J2FORMSID.
        /// </summary>
        public const string J2FORMSID = "J2FORMSID";

        /// <summary>
        /// J2BOXN.
        /// </summary>
        public const string J2BOXN = "J2BOXN";

        /// <summary>
        /// J2CQ.
        /// </summary>
        public const string J2CQ = "J2CQ";

        /// <summary>
        /// J2CASEO.
        /// </summary>
        public const string J2CASEO = "J2CASEO";

        /// <summary>
        /// J2PDBA.
        /// </summary>
        public const string J2PDBA = "J2PDBA";

        /// <summary>
        /// J2UPMJ.
        /// </summary>
        public const string J2UPMJ = "J2UPMJ";

        /// <summary>
        /// J2UPMT.
        /// </summary>
        public const string J2UPMT = "J2UPMT";

        /// <summary>
        /// J2PID.
        /// </summary>
        public const string J2PID = "J2PID";

        /// <summary>
        /// J2JOBN.
        /// </summary>
        public const string J2JOBN = "J2JOBN";

        /// <summary>
        /// J2USER.
        /// </summary>
        public const string J2USER = "J2USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77190";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J2TAXYR", "J2TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J2FORMSID", "J2FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J2BOXN", "J2BOXN", JdeDataType.String, 20, true, true),
        new JdeField("J2CQ", "J2CQ", JdeDataType.String, 120, true, true),
        new JdeField("J2CASEO", "J2CASEO", JdeDataType.String, 4, true, true),
        new JdeField("J2PDBA", "J2PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("J2UPMJ", "J2UPMJ", JdeDataType.Numeric),
        new JdeField("J2UPMT", "J2UPMT", JdeDataType.Numeric),
        new JdeField("J2PID", "J2PID", JdeDataType.String, 20),
        new JdeField("J2JOBN", "J2JOBN", JdeDataType.String, 20),
        new JdeField("J2USER", "J2USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77190_0", "Primary Key on J2TAXYR, J2FORMSID, J2BOXN, J2CQ, J2CASEO, J2PDBA", new[] { "J2TAXYR", "J2FORMSID", "J2BOXN", "J2CQ", "J2CASEO", "J2PDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77190_2", "Index on J2FORMSID, J2TAXYR, J2PDBA, J2BOXN, J2CQ, J2CASEO", new[] { "J2FORMSID", "J2TAXYR", "J2PDBA", "J2BOXN", "J2CQ", "J2CASEO" }),
        new JdeIndex("F77190_3", "Index on J2FORMSID, J2TAXYR, J2PDBA", new[] { "J2FORMSID", "J2TAXYR", "J2PDBA" }),
        new JdeIndex("F77190_4", "Index on J2FORMSID, J2TAXYR, J2PDBA, J2BOXN, J2CASEO", new[] { "J2FORMSID", "J2TAXYR", "J2PDBA", "J2BOXN", "J2CASEO" }),
        new JdeIndex("F77190_5", "Index on J2FORMSID, J2TAXYR, J2PDBA, J2BOXN, J2CQ", new[] { "J2FORMSID", "J2TAXYR", "J2PDBA", "J2BOXN", "J2CQ" })
    };
}
