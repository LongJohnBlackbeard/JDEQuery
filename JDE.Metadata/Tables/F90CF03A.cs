using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF03A - .
/// </summary>
public class F90CF03A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCLANG.
        /// </summary>
        public const string CCLANG = "CCLANG";

        /// <summary>
        /// CCANSWID.
        /// </summary>
        public const string CCANSWID = "CCANSWID";

        /// <summary>
        /// CCANSETID.
        /// </summary>
        public const string CCANSETID = "CCANSETID";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCANSVAL.
        /// </summary>
        public const string CCANSVAL = "CCANSVAL";

        /// <summary>
        /// CCANTDESC.
        /// </summary>
        public const string CCANTDESC = "CCANTDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF03A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCLANG", "CCLANG", JdeDataType.String, 4, true, true),
        new JdeField("CCANSWID", "CCANSWID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCANSETID", "CCANSETID", JdeDataType.Numeric),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCANSVAL", "CCANSVAL", JdeDataType.String, 510),
        new JdeField("CCANTDESC", "CCANTDESC", JdeDataType.String, 508)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF03A_0", "Primary Key on CCANSWID, CCLANG", new[] { "CCANSWID", "CCLANG" }, isUnique: true, isPrimaryKey: true)
    };
}
