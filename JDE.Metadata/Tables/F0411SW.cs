using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0411SW - .
/// </summary>
public class F0411SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSUKID.
        /// </summary>
        public const string SSUKID = "SSUKID";

        /// <summary>
        /// SSAN8.
        /// </summary>
        public const string SSAN8 = "SSAN8";

        /// <summary>
        /// SSCO.
        /// </summary>
        public const string SSCO = "SSCO";

        /// <summary>
        /// SSCRCD.
        /// </summary>
        public const string SSCRCD = "SSCRCD";

        /// <summary>
        /// SSBCRC.
        /// </summary>
        public const string SSBCRC = "SSBCRC";

        /// <summary>
        /// SSAG.
        /// </summary>
        public const string SSAG = "SSAG";

        /// <summary>
        /// SSAAP.
        /// </summary>
        public const string SSAAP = "SSAAP";

        /// <summary>
        /// SSACR.
        /// </summary>
        public const string SSACR = "SSACR";

        /// <summary>
        /// SSFAP.
        /// </summary>
        public const string SSFAP = "SSFAP";

        /// <summary>
        /// SSCDEC.
        /// </summary>
        public const string SSCDEC = "SSCDEC";
    }

    /// <inheritdoc />
    public override string TableName => "F0411SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20, true, true),
        new JdeField("SSUKID", "SSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SSAN8", "SSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SSCO", "SSCO", JdeDataType.String, 10, true, true),
        new JdeField("SSCRCD", "SSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("SSBCRC", "SSBCRC", JdeDataType.String, 6, true, true),
        new JdeField("SSAG", "SSAG", JdeDataType.Numeric),
        new JdeField("SSAAP", "SSAAP", JdeDataType.Numeric),
        new JdeField("SSACR", "SSACR", JdeDataType.Numeric),
        new JdeField("SSFAP", "SSFAP", JdeDataType.Numeric),
        new JdeField("SSCDEC", "SSCDEC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0411SW_0", "Primary Key on SSUSER, SSUKID, SSAN8, SSCO, SSCRCD, SSBCRC", new[] { "SSUSER", "SSUKID", "SSAN8", "SSCO", "SSCRCD", "SSBCRC" }, isUnique: true, isPrimaryKey: true)
    };
}
