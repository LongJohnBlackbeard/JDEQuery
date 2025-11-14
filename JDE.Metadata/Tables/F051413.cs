using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051413 - .
/// </summary>
public class F051413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIINFOTYPE.
        /// </summary>
        public const string SIINFOTYPE = "SIINFOTYPE";

        /// <summary>
        /// SIIMPERCNT.
        /// </summary>
        public const string SIIMPERCNT = "SIIMPERCNT";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIMKEY.
        /// </summary>
        public const string SIMKEY = "SIMKEY";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SIUPMT.
        /// </summary>
        public const string SIUPMT = "SIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIINFOTYPE", "SIINFOTYPE", JdeDataType.String, 4, true, true),
        new JdeField("SIIMPERCNT", "SIIMPERCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIMKEY", "SIMKEY", JdeDataType.String, 30),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051413_0", "Primary Key on SIINFOTYPE, SIIMPERCNT", new[] { "SIINFOTYPE", "SIIMPERCNT" }, isUnique: true, isPrimaryKey: true)
    };
}
