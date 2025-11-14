using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF140 - .
/// </summary>
public class F90CF140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCRTSTID.
        /// </summary>
        public const string CCRTSTID = "CCRTSTID";

        /// <summary>
        /// CCRATENAM.
        /// </summary>
        public const string CCRATENAM = "CCRATENAM";

        /// <summary>
        /// CCRTSTDESC.
        /// </summary>
        public const string CCRTSTDESC = "CCRTSTDESC";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCRTSTID", "CCRTSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCRATENAM", "CCRATENAM", JdeDataType.String, 80),
        new JdeField("CCRTSTDESC", "CCRTSTDESC", JdeDataType.String, 508),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF140_0", "Primary Key on CCRTSTID", new[] { "CCRTSTID" }, isUnique: true, isPrimaryKey: true)
    };
}
