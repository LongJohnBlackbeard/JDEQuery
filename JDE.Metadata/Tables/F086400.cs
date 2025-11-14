using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F086400 - .
/// </summary>
public class F086400 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ORJOBS.
        /// </summary>
        public const string ORJOBS = "ORJOBS";

        /// <summary>
        /// ORESTB.
        /// </summary>
        public const string ORESTB = "ORESTB";

        /// <summary>
        /// ORJOBN.
        /// </summary>
        public const string ORJOBN = "ORJOBN";

        /// <summary>
        /// ORUPMJ.
        /// </summary>
        public const string ORUPMJ = "ORUPMJ";

        /// <summary>
        /// ORPID.
        /// </summary>
        public const string ORPID = "ORPID";

        /// <summary>
        /// ORUSER.
        /// </summary>
        public const string ORUSER = "ORUSER";

        /// <summary>
        /// ORUPMT.
        /// </summary>
        public const string ORUPMT = "ORUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F086400";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ORJOBS", "ORJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ORESTB", "ORESTB", JdeDataType.Numeric, null, true, true),
        new JdeField("ORJOBN", "ORJOBN", JdeDataType.String, 20),
        new JdeField("ORUPMJ", "ORUPMJ", JdeDataType.Numeric),
        new JdeField("ORPID", "ORPID", JdeDataType.String, 20),
        new JdeField("ORUSER", "ORUSER", JdeDataType.String, 20),
        new JdeField("ORUPMT", "ORUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F086400_0", "Primary Key on ORJOBS, ORESTB", new[] { "ORJOBS", "ORESTB" }, isUnique: true, isPrimaryKey: true)
    };
}
