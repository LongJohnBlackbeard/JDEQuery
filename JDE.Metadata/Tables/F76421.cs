using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76421 - .
/// </summary>
public class F76421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIDOCO.
        /// </summary>
        public const string SIDOCO = "SIDOCO";

        /// <summary>
        /// SIDCTO.
        /// </summary>
        public const string SIDCTO = "SIDCTO";

        /// <summary>
        /// SIKCOO.
        /// </summary>
        public const string SIKCOO = "SIKCOO";

        /// <summary>
        /// SISFXO.
        /// </summary>
        public const string SISFXO = "SISFXO";

        /// <summary>
        /// SIBNOP.
        /// </summary>
        public const string SIBNOP = "SIBNOP";

        /// <summary>
        /// SIBSOP.
        /// </summary>
        public const string SIBSOP = "SIBSOP";

        /// <summary>
        /// SIAN8.
        /// </summary>
        public const string SIAN8 = "SIAN8";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIJOBN.
        /// </summary>
        public const string SIJOBN = "SIJOBN";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SITDAY.
        /// </summary>
        public const string SITDAY = "SITDAY";

        /// <summary>
        /// SIBFIIS.
        /// </summary>
        public const string SIBFIIS = "SIBFIIS";
    }

    /// <inheritdoc />
    public override string TableName => "F76421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIDOCO", "SIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SIDCTO", "SIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SIKCOO", "SIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SISFXO", "SISFXO", JdeDataType.String, 6),
        new JdeField("SIBNOP", "SIBNOP", JdeDataType.Numeric),
        new JdeField("SIBSOP", "SIBSOP", JdeDataType.String, 4),
        new JdeField("SIAN8", "SIAN8", JdeDataType.Numeric),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SITDAY", "SITDAY", JdeDataType.Numeric),
        new JdeField("SIBFIIS", "SIBFIIS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76421_0", "Primary Key on SIDOCO, SIDCTO, SIKCOO", new[] { "SIDOCO", "SIDCTO", "SIKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
