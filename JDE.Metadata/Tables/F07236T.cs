using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07236T - .
/// </summary>
public class F07236T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y6HMCO.
        /// </summary>
        public const string Y6HMCO = "Y6HMCO";

        /// <summary>
        /// Y6HMCU.
        /// </summary>
        public const string Y6HMCU = "Y6HMCU";

        /// <summary>
        /// Y6SEC.
        /// </summary>
        public const string Y6SEC = "Y6SEC";

        /// <summary>
        /// Y6AN8.
        /// </summary>
        public const string Y6AN8 = "Y6AN8";

        /// <summary>
        /// Y6NQUAL.
        /// </summary>
        public const string Y6NQUAL = "Y6NQUAL";

        /// <summary>
        /// Y6FDFI.
        /// </summary>
        public const string Y6FDFI = "Y6FDFI";

        /// <summary>
        /// Y6IAT13.
        /// </summary>
        public const string Y6IAT13 = "Y6IAT13";

        /// <summary>
        /// Y6IAT14.
        /// </summary>
        public const string Y6IAT14 = "Y6IAT14";

        /// <summary>
        /// Y6IAT15.
        /// </summary>
        public const string Y6IAT15 = "Y6IAT15";

        /// <summary>
        /// Y6IAT16.
        /// </summary>
        public const string Y6IAT16 = "Y6IAT16";

        /// <summary>
        /// Y6IAT17.
        /// </summary>
        public const string Y6IAT17 = "Y6IAT17";

        /// <summary>
        /// Y6IAT18.
        /// </summary>
        public const string Y6IAT18 = "Y6IAT18";

        /// <summary>
        /// Y6IAT19.
        /// </summary>
        public const string Y6IAT19 = "Y6IAT19";

        /// <summary>
        /// Y6IAT20.
        /// </summary>
        public const string Y6IAT20 = "Y6IAT20";

        /// <summary>
        /// Y6IAT21.
        /// </summary>
        public const string Y6IAT21 = "Y6IAT21";

        /// <summary>
        /// Y6IAT22.
        /// </summary>
        public const string Y6IAT22 = "Y6IAT22";

        /// <summary>
        /// Y6IAT23.
        /// </summary>
        public const string Y6IAT23 = "Y6IAT23";

        /// <summary>
        /// Y6IAT24.
        /// </summary>
        public const string Y6IAT24 = "Y6IAT24";

        /// <summary>
        /// Y6UPMJ.
        /// </summary>
        public const string Y6UPMJ = "Y6UPMJ";

        /// <summary>
        /// Y6UPMT.
        /// </summary>
        public const string Y6UPMT = "Y6UPMT";

        /// <summary>
        /// Y6PID.
        /// </summary>
        public const string Y6PID = "Y6PID";

        /// <summary>
        /// Y6JOBN.
        /// </summary>
        public const string Y6JOBN = "Y6JOBN";

        /// <summary>
        /// Y6USER.
        /// </summary>
        public const string Y6USER = "Y6USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07236T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y6HMCO", "Y6HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y6HMCU", "Y6HMCU", JdeDataType.String, 24, true, true),
        new JdeField("Y6SEC", "Y6SEC", JdeDataType.String, 6),
        new JdeField("Y6AN8", "Y6AN8", JdeDataType.Numeric),
        new JdeField("Y6NQUAL", "Y6NQUAL", JdeDataType.String, 4),
        new JdeField("Y6FDFI", "Y6FDFI", JdeDataType.String, 68),
        new JdeField("Y6IAT13", "Y6IAT13", JdeDataType.Numeric),
        new JdeField("Y6IAT14", "Y6IAT14", JdeDataType.Numeric),
        new JdeField("Y6IAT15", "Y6IAT15", JdeDataType.Numeric),
        new JdeField("Y6IAT16", "Y6IAT16", JdeDataType.String, 70),
        new JdeField("Y6IAT17", "Y6IAT17", JdeDataType.String, 70),
        new JdeField("Y6IAT18", "Y6IAT18", JdeDataType.String, 70),
        new JdeField("Y6IAT19", "Y6IAT19", JdeDataType.Numeric),
        new JdeField("Y6IAT20", "Y6IAT20", JdeDataType.Numeric),
        new JdeField("Y6IAT21", "Y6IAT21", JdeDataType.Numeric),
        new JdeField("Y6IAT22", "Y6IAT22", JdeDataType.String, 2),
        new JdeField("Y6IAT23", "Y6IAT23", JdeDataType.String, 2),
        new JdeField("Y6IAT24", "Y6IAT24", JdeDataType.String, 2),
        new JdeField("Y6UPMJ", "Y6UPMJ", JdeDataType.Numeric),
        new JdeField("Y6UPMT", "Y6UPMT", JdeDataType.Numeric),
        new JdeField("Y6PID", "Y6PID", JdeDataType.String, 20),
        new JdeField("Y6JOBN", "Y6JOBN", JdeDataType.String, 20),
        new JdeField("Y6USER", "Y6USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07236T_0", "Primary Key on Y6HMCO, Y6HMCU", new[] { "Y6HMCO", "Y6HMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
