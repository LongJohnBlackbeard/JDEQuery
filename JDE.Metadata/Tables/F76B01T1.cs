using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B01T1 - .
/// </summary>
public class F76B01T1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHBNNF.
        /// </summary>
        public const string FHBNNF = "FHBNNF";

        /// <summary>
        /// FHBSER.
        /// </summary>
        public const string FHBSER = "FHBSER";

        /// <summary>
        /// FHN001.
        /// </summary>
        public const string FHN001 = "FHN001";

        /// <summary>
        /// FHDCT.
        /// </summary>
        public const string FHDCT = "FHDCT";

        /// <summary>
        /// FHDOCBLOB.
        /// </summary>
        public const string FHDOCBLOB = "FHDOCBLOB";

        /// <summary>
        /// FHTORG.
        /// </summary>
        public const string FHTORG = "FHTORG";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";

        /// <summary>
        /// FHUPMT.
        /// </summary>
        public const string FHUPMT = "FHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B01T1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHBNNF", "FHBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FHBSER", "FHBSER", JdeDataType.String, 4, true, true),
        new JdeField("FHN001", "FHN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FHDCT", "FHDCT", JdeDataType.String, 4, true, true),
        new JdeField("FHDOCBLOB", "FHDOCBLOB", JdeDataType.String),
        new JdeField("FHTORG", "FHTORG", JdeDataType.String, 20),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHUPMT", "FHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B01T1_0", "Primary Key on FHBNNF, FHBSER, FHN001, FHDCT", new[] { "FHBNNF", "FHBSER", "FHN001", "FHDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
