using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0200 - .
/// </summary>
public class FD3N0200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLAN8.
        /// </summary>
        public const string JLAN8 = "JLAN8";

        /// <summary>
        /// JLDTI1.
        /// </summary>
        public const string JLDTI1 = "JLDTI1";

        /// <summary>
        /// JLDSE.
        /// </summary>
        public const string JLDSE = "JLDSE";

        /// <summary>
        /// JLDEE.
        /// </summary>
        public const string JLDEE = "JLDEE";

        /// <summary>
        /// JLACTI.
        /// </summary>
        public const string JLACTI = "JLACTI";

        /// <summary>
        /// JLWOD.
        /// </summary>
        public const string JLWOD = "JLWOD";

        /// <summary>
        /// JLDCTO.
        /// </summary>
        public const string JLDCTO = "JLDCTO";

        /// <summary>
        /// JLCLCT.
        /// </summary>
        public const string JLCLCT = "JLCLCT";

        /// <summary>
        /// JLAOPS.
        /// </summary>
        public const string JLAOPS = "JLAOPS";

        /// <summary>
        /// JLUSER.
        /// </summary>
        public const string JLUSER = "JLUSER";

        /// <summary>
        /// JLPID.
        /// </summary>
        public const string JLPID = "JLPID";

        /// <summary>
        /// JLUPMJ.
        /// </summary>
        public const string JLUPMJ = "JLUPMJ";

        /// <summary>
        /// JLJOBN.
        /// </summary>
        public const string JLJOBN = "JLJOBN";

        /// <summary>
        /// JLUPMT.
        /// </summary>
        public const string JLUPMT = "JLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLAN8", "JLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JLDTI1", "JLDTI1", JdeDataType.String, 20, true, true),
        new JdeField("JLDSE", "JLDSE", JdeDataType.Numeric, null, true, true),
        new JdeField("JLDEE", "JLDEE", JdeDataType.Numeric),
        new JdeField("JLACTI", "JLACTI", JdeDataType.String, 2),
        new JdeField("JLWOD", "JLWOD", JdeDataType.Numeric),
        new JdeField("JLDCTO", "JLDCTO", JdeDataType.String, 4),
        new JdeField("JLCLCT", "JLCLCT", JdeDataType.String, 60),
        new JdeField("JLAOPS", "JLAOPS", JdeDataType.Numeric),
        new JdeField("JLUSER", "JLUSER", JdeDataType.String, 20),
        new JdeField("JLPID", "JLPID", JdeDataType.String, 20),
        new JdeField("JLUPMJ", "JLUPMJ", JdeDataType.Numeric),
        new JdeField("JLJOBN", "JLJOBN", JdeDataType.String, 20),
        new JdeField("JLUPMT", "JLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0200_0", "Primary Key on JLAN8, JLDTI1, JLDSE", new[] { "JLAN8", "JLDTI1", "JLDSE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N0200_1", "Unique Index on JLAN8, JLDTI1, JLDSE, JLDEE", new[] { "JLAN8", "JLDTI1", "JLDSE", "JLDEE" }, isUnique: true),
        new JdeIndex("FD3N0200_2", "Index on JLAN8", new[] { "JLAN8" })
    };
}
