using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D241 - .
/// </summary>
public class F80D241 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOPRDJ.
        /// </summary>
        public const string SOPRDJ = "SOPRDJ";

        /// <summary>
        /// SOEMCU.
        /// </summary>
        public const string SOEMCU = "SOEMCU";

        /// <summary>
        /// SOAN8.
        /// </summary>
        public const string SOAN8 = "SOAN8";

        /// <summary>
        /// SOITM.
        /// </summary>
        public const string SOITM = "SOITM";

        /// <summary>
        /// SOSHRV.
        /// </summary>
        public const string SOSHRV = "SOSHRV";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOPID.
        /// </summary>
        public const string SOPID = "SOPID";

        /// <summary>
        /// SOMKEY.
        /// </summary>
        public const string SOMKEY = "SOMKEY";

        /// <summary>
        /// SOUTIME.
        /// </summary>
        public const string SOUTIME = "SOUTIME";

        /// <summary>
        /// SOURCD.
        /// </summary>
        public const string SOURCD = "SOURCD";

        /// <summary>
        /// SOURDT.
        /// </summary>
        public const string SOURDT = "SOURDT";

        /// <summary>
        /// SOURAT.
        /// </summary>
        public const string SOURAT = "SOURAT";

        /// <summary>
        /// SOURAB.
        /// </summary>
        public const string SOURAB = "SOURAB";

        /// <summary>
        /// SOURRF.
        /// </summary>
        public const string SOURRF = "SOURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D241";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOPRDJ", "SOPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SOEMCU", "SOEMCU", JdeDataType.String, 24, true, true),
        new JdeField("SOAN8", "SOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SOITM", "SOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SOSHRV", "SOSHRV", JdeDataType.Numeric),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20),
        new JdeField("SOPID", "SOPID", JdeDataType.String, 20),
        new JdeField("SOMKEY", "SOMKEY", JdeDataType.String, 30),
        new JdeField("SOUTIME", "SOUTIME", JdeDataType.Date),
        new JdeField("SOURCD", "SOURCD", JdeDataType.String, 4),
        new JdeField("SOURDT", "SOURDT", JdeDataType.Numeric),
        new JdeField("SOURAT", "SOURAT", JdeDataType.Numeric),
        new JdeField("SOURAB", "SOURAB", JdeDataType.Numeric),
        new JdeField("SOURRF", "SOURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D241_0", "Primary Key on SOPRDJ, SOEMCU, SOAN8, SOITM", new[] { "SOPRDJ", "SOEMCU", "SOAN8", "SOITM" }, isUnique: true, isPrimaryKey: true)
    };
}
