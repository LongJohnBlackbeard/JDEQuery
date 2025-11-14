using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CI3 - .
/// </summary>
public class F76CI3 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TATXA1.
        /// </summary>
        public const string TATXA1 = "TATXA1";

        /// <summary>
        /// TAEFDJ.
        /// </summary>
        public const string TAEFDJ = "TAEFDJ";

        /// <summary>
        /// TAITM.
        /// </summary>
        public const string TAITM = "TAITM";

        /// <summary>
        /// TACCRT.
        /// </summary>
        public const string TACCRT = "TACCRT";

        /// <summary>
        /// TACJCS.
        /// </summary>
        public const string TACJCS = "TACJCS";

        /// <summary>
        /// TACJCV.
        /// </summary>
        public const string TACJCV = "TACJCV";

        /// <summary>
        /// TACTC1.
        /// </summary>
        public const string TACTC1 = "TACTC1";

        /// <summary>
        /// TACTC2.
        /// </summary>
        public const string TACTC2 = "TACTC2";

        /// <summary>
        /// TACTC3.
        /// </summary>
        public const string TACTC3 = "TACTC3";

        /// <summary>
        /// TACTC4.
        /// </summary>
        public const string TACTC4 = "TACTC4";

        /// <summary>
        /// TACTC5.
        /// </summary>
        public const string TACTC5 = "TACTC5";

        /// <summary>
        /// TACCS1.
        /// </summary>
        public const string TACCS1 = "TACCS1";

        /// <summary>
        /// TACCS2.
        /// </summary>
        public const string TACCS2 = "TACCS2";

        /// <summary>
        /// TACCS3.
        /// </summary>
        public const string TACCS3 = "TACCS3";

        /// <summary>
        /// TACCS4.
        /// </summary>
        public const string TACCS4 = "TACCS4";

        /// <summary>
        /// TACCS5.
        /// </summary>
        public const string TACCS5 = "TACCS5";

        /// <summary>
        /// TACCV1.
        /// </summary>
        public const string TACCV1 = "TACCV1";

        /// <summary>
        /// TACCV2.
        /// </summary>
        public const string TACCV2 = "TACCV2";

        /// <summary>
        /// TACCV3.
        /// </summary>
        public const string TACCV3 = "TACCV3";

        /// <summary>
        /// TACCV4.
        /// </summary>
        public const string TACCV4 = "TACCV4";

        /// <summary>
        /// TACCV5.
        /// </summary>
        public const string TACCV5 = "TACCV5";

        /// <summary>
        /// TACAGT.
        /// </summary>
        public const string TACAGT = "TACAGT";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76CI3";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TATXA1", "TATXA1", JdeDataType.String, 20, true, true),
        new JdeField("TAEFDJ", "TAEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TAITM", "TAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TACCRT", "TACCRT", JdeDataType.String, 6),
        new JdeField("TACJCS", "TACJCS", JdeDataType.String, 6),
        new JdeField("TACJCV", "TACJCV", JdeDataType.String, 6),
        new JdeField("TACTC1", "TACTC1", JdeDataType.String, 6),
        new JdeField("TACTC2", "TACTC2", JdeDataType.String, 6),
        new JdeField("TACTC3", "TACTC3", JdeDataType.String, 6),
        new JdeField("TACTC4", "TACTC4", JdeDataType.String, 6),
        new JdeField("TACTC5", "TACTC5", JdeDataType.String, 6),
        new JdeField("TACCS1", "TACCS1", JdeDataType.String, 6),
        new JdeField("TACCS2", "TACCS2", JdeDataType.String, 6),
        new JdeField("TACCS3", "TACCS3", JdeDataType.String, 6),
        new JdeField("TACCS4", "TACCS4", JdeDataType.String, 6),
        new JdeField("TACCS5", "TACCS5", JdeDataType.String, 6),
        new JdeField("TACCV1", "TACCV1", JdeDataType.String, 6),
        new JdeField("TACCV2", "TACCV2", JdeDataType.String, 6),
        new JdeField("TACCV3", "TACCV3", JdeDataType.String, 6),
        new JdeField("TACCV4", "TACCV4", JdeDataType.String, 6),
        new JdeField("TACCV5", "TACCV5", JdeDataType.String, 6),
        new JdeField("TACAGT", "TACAGT", JdeDataType.String, 20),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CI3_0", "Primary Key on TATXA1, TAITM, TAEFDJ", new[] { "TATXA1", "TAITM", "TAEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
