using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F11151 - .
/// </summary>
public class F11151 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CECRCD.
        /// </summary>
        public const string CECRCD = "CECRCD";

        /// <summary>
        /// CECRDC.
        /// </summary>
        public const string CECRDC = "CECRDC";

        /// <summary>
        /// CEAN8.
        /// </summary>
        public const string CEAN8 = "CEAN8";

        /// <summary>
        /// CESQNA.
        /// </summary>
        public const string CESQNA = "CESQNA";

        /// <summary>
        /// CECEFJ.
        /// </summary>
        public const string CECEFJ = "CECEFJ";

        /// <summary>
        /// CECCF1.
        /// </summary>
        public const string CECCF1 = "CECCF1";

        /// <summary>
        /// CECCT1.
        /// </summary>
        public const string CECCT1 = "CECCT1";

        /// <summary>
        /// CECCA1.
        /// </summary>
        public const string CECCA1 = "CECCA1";

        /// <summary>
        /// CECCF2.
        /// </summary>
        public const string CECCF2 = "CECCF2";

        /// <summary>
        /// CECCT2.
        /// </summary>
        public const string CECCT2 = "CECCT2";

        /// <summary>
        /// CECCA2.
        /// </summary>
        public const string CECCA2 = "CECCA2";

        /// <summary>
        /// CECCAI.
        /// </summary>
        public const string CECCAI = "CECCAI";

        /// <summary>
        /// CEUPMJ.
        /// </summary>
        public const string CEUPMJ = "CEUPMJ";

        /// <summary>
        /// CEUPMT.
        /// </summary>
        public const string CEUPMT = "CEUPMT";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEPID.
        /// </summary>
        public const string CEPID = "CEPID";
    }

    /// <inheritdoc />
    public override string TableName => "F11151";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CECRCD", "CECRCD", JdeDataType.String, 6, true, true),
        new JdeField("CECRDC", "CECRDC", JdeDataType.String, 6, true, true),
        new JdeField("CEAN8", "CEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CESQNA", "CESQNA", JdeDataType.Numeric, null, true, true),
        new JdeField("CECEFJ", "CECEFJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CECCF1", "CECCF1", JdeDataType.String, 6),
        new JdeField("CECCT1", "CECCT1", JdeDataType.String, 6),
        new JdeField("CECCA1", "CECCA1", JdeDataType.Numeric),
        new JdeField("CECCF2", "CECCF2", JdeDataType.String, 6),
        new JdeField("CECCT2", "CECCT2", JdeDataType.String, 6),
        new JdeField("CECCA2", "CECCA2", JdeDataType.Numeric),
        new JdeField("CECCAI", "CECCAI", JdeDataType.String, 2),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEPID", "CEPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F11151_0", "Primary Key on CECRCD, CECRDC, CEAN8, CESQNA, CECEFJ", new[] { "CECRCD", "CECRDC", "CEAN8", "CESQNA", "CECEFJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F11151_2", "Index on CECRCD, CESQNA, CEAN8", new[] { "CECRCD", "CESQNA", "CEAN8" }),
        new JdeIndex("F11151_3", "Index on CESQNA, CECRCD, CECRDC, CEAN8", new[] { "CESQNA", "CECRCD", "CECRDC", "CEAN8" }),
        new JdeIndex("F11151_4", "Index on CECRCD, CECRDC, CEAN8, CESQNA", new[] { "CECRCD", "CECRDC", "CEAN8", "CESQNA" }),
        new JdeIndex("F11151_5", "Index on CECRDC, CESQNA, CEAN8", new[] { "CECRDC", "CESQNA", "CEAN8" })
    };
}
