using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B001 - .
/// </summary>
public class F76B001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THBNNF.
        /// </summary>
        public const string THBNNF = "THBNNF";

        /// <summary>
        /// THBSER.
        /// </summary>
        public const string THBSER = "THBSER";

        /// <summary>
        /// THN001.
        /// </summary>
        public const string THN001 = "THN001";

        /// <summary>
        /// THDCT.
        /// </summary>
        public const string THDCT = "THDCT";

        /// <summary>
        /// THBRTX.
        /// </summary>
        public const string THBRTX = "THBRTX";

        /// <summary>
        /// THBRTXB.
        /// </summary>
        public const string THBRTXB = "THBRTXB";

        /// <summary>
        /// THBRTXA.
        /// </summary>
        public const string THBRTXA = "THBRTXA";

        /// <summary>
        /// THC1FU.
        /// </summary>
        public const string THC1FU = "THC1FU";

        /// <summary>
        /// THC2FU.
        /// </summary>
        public const string THC2FU = "THC2FU";

        /// <summary>
        /// THD1FU.
        /// </summary>
        public const string THD1FU = "THD1FU";

        /// <summary>
        /// THD2FU.
        /// </summary>
        public const string THD2FU = "THD2FU";

        /// <summary>
        /// THN1FU.
        /// </summary>
        public const string THN1FU = "THN1FU";

        /// <summary>
        /// THN8FU.
        /// </summary>
        public const string THN8FU = "THN8FU";

        /// <summary>
        /// THN9FU.
        /// </summary>
        public const string THN9FU = "THN9FU";

        /// <summary>
        /// THN10FU.
        /// </summary>
        public const string THN10FU = "THN10FU";

        /// <summary>
        /// THN4FU.
        /// </summary>
        public const string THN4FU = "THN4FU";

        /// <summary>
        /// THS1FU.
        /// </summary>
        public const string THS1FU = "THS1FU";

        /// <summary>
        /// THS3FU.
        /// </summary>
        public const string THS3FU = "THS3FU";

        /// <summary>
        /// THGENLNG.
        /// </summary>
        public const string THGENLNG = "THGENLNG";

        /// <summary>
        /// THTORG.
        /// </summary>
        public const string THTORG = "THTORG";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THBNNF", "THBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("THBSER", "THBSER", JdeDataType.String, 4, true, true),
        new JdeField("THN001", "THN001", JdeDataType.Numeric, null, true, true),
        new JdeField("THDCT", "THDCT", JdeDataType.String, 4, true, true),
        new JdeField("THBRTX", "THBRTX", JdeDataType.String, 4, true, true),
        new JdeField("THBRTXB", "THBRTXB", JdeDataType.Numeric),
        new JdeField("THBRTXA", "THBRTXA", JdeDataType.Numeric),
        new JdeField("THC1FU", "THC1FU", JdeDataType.String, 2),
        new JdeField("THC2FU", "THC2FU", JdeDataType.String, 2),
        new JdeField("THD1FU", "THD1FU", JdeDataType.Numeric),
        new JdeField("THD2FU", "THD2FU", JdeDataType.Numeric),
        new JdeField("THN1FU", "THN1FU", JdeDataType.Numeric),
        new JdeField("THN8FU", "THN8FU", JdeDataType.Numeric),
        new JdeField("THN9FU", "THN9FU", JdeDataType.Numeric),
        new JdeField("THN10FU", "THN10FU", JdeDataType.Numeric),
        new JdeField("THN4FU", "THN4FU", JdeDataType.Numeric),
        new JdeField("THS1FU", "THS1FU", JdeDataType.String, 60),
        new JdeField("THS3FU", "THS3FU", JdeDataType.String, 6),
        new JdeField("THGENLNG", "THGENLNG", JdeDataType.Numeric),
        new JdeField("THTORG", "THTORG", JdeDataType.String, 20),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B001_0", "Primary Key on THBNNF, THBSER, THN001, THDCT, THBRTX", new[] { "THBNNF", "THBSER", "THN001", "THDCT", "THBRTX" }, isUnique: true, isPrimaryKey: true)
    };
}
