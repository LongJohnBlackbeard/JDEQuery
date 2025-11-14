using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0F01 - .
/// </summary>
public class F76C0F01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHC76FMT.
        /// </summary>
        public const string FHC76FMT = "FHC76FMT";

        /// <summary>
        /// FHC76SND.
        /// </summary>
        public const string FHC76SND = "FHC76SND";

        /// <summary>
        /// FHC76FSND.
        /// </summary>
        public const string FHC76FSND = "FHC76FSND";

        /// <summary>
        /// FHC76XMLV.
        /// </summary>
        public const string FHC76XMLV = "FHC76XMLV";

        /// <summary>
        /// FHC76XMLC.
        /// </summary>
        public const string FHC76XMLC = "FHC76XMLC";

        /// <summary>
        /// FHAA1.
        /// </summary>
        public const string FHAA1 = "FHAA1";

        /// <summary>
        /// FHQTY.
        /// </summary>
        public const string FHQTY = "FHQTY";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHVERS.
        /// </summary>
        public const string FHVERS = "FHVERS";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHUPMT.
        /// </summary>
        public const string FHUPMT = "FHUPMT";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0F01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHC76FMT", "FHC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("FHC76SND", "FHC76SND", JdeDataType.Numeric, null, true, true),
        new JdeField("FHC76FSND", "FHC76FSND", JdeDataType.Numeric, null, true, true),
        new JdeField("FHC76XMLV", "FHC76XMLV", JdeDataType.String, 4),
        new JdeField("FHC76XMLC", "FHC76XMLC", JdeDataType.String, 4),
        new JdeField("FHAA1", "FHAA1", JdeDataType.Numeric),
        new JdeField("FHQTY", "FHQTY", JdeDataType.Numeric),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHVERS", "FHVERS", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHUPMT", "FHUPMT", JdeDataType.Numeric),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0F01_0", "Primary Key on FHC76FMT, FHC76SND, FHC76FSND", new[] { "FHC76FMT", "FHC76SND", "FHC76FSND" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C0F01_2", "Index on FHC76FMT, SYS_NC00014$, SYS_NC00015$", new[] { "FHC76FMT", "SYS_NC00014$", "SYS_NC00015$" })
    };
}
