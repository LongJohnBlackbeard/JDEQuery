using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW011 - .
/// </summary>
public class FCW011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTC9LVTC.
        /// </summary>
        public const string LTC9LVTC = "LTC9LVTC";

        /// <summary>
        /// LTC9DSC1.
        /// </summary>
        public const string LTC9DSC1 = "LTC9DSC1";

        /// <summary>
        /// LTC9BRP.
        /// </summary>
        public const string LTC9BRP = "LTC9BRP";

        /// <summary>
        /// LTC9BRW.
        /// </summary>
        public const string LTC9BRW = "LTC9BRW";

        /// <summary>
        /// LTC9BRV.
        /// </summary>
        public const string LTC9BRV = "LTC9BRV";

        /// <summary>
        /// LTC9BSFN.
        /// </summary>
        public const string LTC9BSFN = "LTC9BSFN";

        /// <summary>
        /// LTC9CRP.
        /// </summary>
        public const string LTC9CRP = "LTC9CRP";

        /// <summary>
        /// LTC9CRW.
        /// </summary>
        public const string LTC9CRW = "LTC9CRW";

        /// <summary>
        /// LTC9CRV.
        /// </summary>
        public const string LTC9CRV = "LTC9CRV";

        /// <summary>
        /// LTC9SY.
        /// </summary>
        public const string LTC9SY = "LTC9SY";

        /// <summary>
        /// LTC9RT.
        /// </summary>
        public const string LTC9RT = "LTC9RT";

        /// <summary>
        /// LTC9CDDE.
        /// </summary>
        public const string LTC9CDDE = "LTC9CDDE";

        /// <summary>
        /// LTC9CLN.
        /// </summary>
        public const string LTC9CLN = "LTC9CLN";

        /// <summary>
        /// LTC9CPOS.
        /// </summary>
        public const string LTC9CPOS = "LTC9CPOS";

        /// <summary>
        /// LTC9DTAI.
        /// </summary>
        public const string LTC9DTAI = "LTC9DTAI";

        /// <summary>
        /// LTC9DTAG.
        /// </summary>
        public const string LTC9DTAG = "LTC9DTAG";
    }

    /// <inheritdoc />
    public override string TableName => "FCW011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTC9LVTC", "LTC9LVTC", JdeDataType.String, 6, true, true),
        new JdeField("LTC9DSC1", "LTC9DSC1", JdeDataType.String, 60),
        new JdeField("LTC9BRP", "LTC9BRP", JdeDataType.String, 20),
        new JdeField("LTC9BRW", "LTC9BRW", JdeDataType.String, 20),
        new JdeField("LTC9BRV", "LTC9BRV", JdeDataType.String, 20),
        new JdeField("LTC9BSFN", "LTC9BSFN", JdeDataType.String, 20),
        new JdeField("LTC9CRP", "LTC9CRP", JdeDataType.String, 20),
        new JdeField("LTC9CRW", "LTC9CRW", JdeDataType.String, 20),
        new JdeField("LTC9CRV", "LTC9CRV", JdeDataType.String, 20),
        new JdeField("LTC9SY", "LTC9SY", JdeDataType.String, 8),
        new JdeField("LTC9RT", "LTC9RT", JdeDataType.String, 4),
        new JdeField("LTC9CDDE", "LTC9CDDE", JdeDataType.String, 2),
        new JdeField("LTC9CLN", "LTC9CLN", JdeDataType.Numeric),
        new JdeField("LTC9CPOS", "LTC9CPOS", JdeDataType.Numeric),
        new JdeField("LTC9DTAI", "LTC9DTAI", JdeDataType.String, 20),
        new JdeField("LTC9DTAG", "LTC9DTAG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW011_0", "Primary Key on LTC9LVTC", new[] { "LTC9LVTC" }, isUnique: true, isPrimaryKey: true)
    };
}
