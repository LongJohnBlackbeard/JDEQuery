using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90005 - .
/// </summary>
public class F90005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPIDROW.
        /// </summary>
        public const string SPIDROW = "SPIDROW";

        /// <summary>
        /// SPTHANDL.
        /// </summary>
        public const string SPTHANDL = "SPTHANDL";

        /// <summary>
        /// SPTHNDAT.
        /// </summary>
        public const string SPTHNDAT = "SPTHNDAT";

        /// <summary>
        /// SPFUTUSE1.
        /// </summary>
        public const string SPFUTUSE1 = "SPFUTUSE1";

        /// <summary>
        /// SPFUTUSE3.
        /// </summary>
        public const string SPFUTUSE3 = "SPFUTUSE3";

        /// <summary>
        /// SPFUTUSE24.
        /// </summary>
        public const string SPFUTUSE24 = "SPFUTUSE24";

        /// <summary>
        /// SPFUTUSE25.
        /// </summary>
        public const string SPFUTUSE25 = "SPFUTUSE25";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F90005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPIDROW", "SPIDROW", JdeDataType.Numeric, null, true, true),
        new JdeField("SPTHANDL", "SPTHANDL", JdeDataType.String, 64),
        new JdeField("SPTHNDAT", "SPTHNDAT", JdeDataType.String, 512),
        new JdeField("SPFUTUSE1", "SPFUTUSE1", JdeDataType.String, 8),
        new JdeField("SPFUTUSE3", "SPFUTUSE3", JdeDataType.String, 8),
        new JdeField("SPFUTUSE24", "SPFUTUSE24", JdeDataType.String, 20),
        new JdeField("SPFUTUSE25", "SPFUTUSE25", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90005_0", "Primary Key on SPIDROW", new[] { "SPIDROW" }, isUnique: true, isPrimaryKey: true)
    };
}
