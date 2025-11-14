using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B72 - .
/// </summary>
public class F31B72 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VDWOPID.
        /// </summary>
        public const string VDWOPID = "VDWOPID";

        /// <summary>
        /// VDWV2VLNID.
        /// </summary>
        public const string VDWV2VLNID = "VDWV2VLNID";

        /// <summary>
        /// VDWFTF.
        /// </summary>
        public const string VDWFTF = "VDWFTF";

        /// <summary>
        /// VDWBAD.
        /// </summary>
        public const string VDWBAD = "VDWBAD";

        /// <summary>
        /// VDWPDIP.
        /// </summary>
        public const string VDWPDIP = "VDWPDIP";

        /// <summary>
        /// VDWADIP.
        /// </summary>
        public const string VDWADIP = "VDWADIP";

        /// <summary>
        /// VDWDUM.
        /// </summary>
        public const string VDWDUM = "VDWDUM";

        /// <summary>
        /// VDWPVL.
        /// </summary>
        public const string VDWPVL = "VDWPVL";

        /// <summary>
        /// VDWAVL.
        /// </summary>
        public const string VDWAVL = "VDWAVL";

        /// <summary>
        /// VDWVUM.
        /// </summary>
        public const string VDWVUM = "VDWVUM";

        /// <summary>
        /// VDTDPT.
        /// </summary>
        public const string VDTDPT = "VDTDPT";

        /// <summary>
        /// VDWIF.
        /// </summary>
        public const string VDWIF = "VDWIF";

        /// <summary>
        /// VDWAF.
        /// </summary>
        public const string VDWAF = "VDWAF";

        /// <summary>
        /// VDUSER.
        /// </summary>
        public const string VDUSER = "VDUSER";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDJOBN.
        /// </summary>
        public const string VDJOBN = "VDJOBN";

        /// <summary>
        /// VDUPMJ.
        /// </summary>
        public const string VDUPMJ = "VDUPMJ";

        /// <summary>
        /// VDTDAY.
        /// </summary>
        public const string VDTDAY = "VDTDAY";

        /// <summary>
        /// VDWAAVL.
        /// </summary>
        public const string VDWAAVL = "VDWAAVL";

        /// <summary>
        /// VDCACR2.
        /// </summary>
        public const string VDCACR2 = "VDCACR2";
    }

    /// <inheritdoc />
    public override string TableName => "F31B72";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VDWOPID", "VDWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDWV2VLNID", "VDWV2VLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VDWFTF", "VDWFTF", JdeDataType.String, 2, true, true),
        new JdeField("VDWBAD", "VDWBAD", JdeDataType.String, 2, true, true),
        new JdeField("VDWPDIP", "VDWPDIP", JdeDataType.Numeric),
        new JdeField("VDWADIP", "VDWADIP", JdeDataType.Numeric),
        new JdeField("VDWDUM", "VDWDUM", JdeDataType.String, 6),
        new JdeField("VDWPVL", "VDWPVL", JdeDataType.Numeric),
        new JdeField("VDWAVL", "VDWAVL", JdeDataType.Numeric),
        new JdeField("VDWVUM", "VDWVUM", JdeDataType.String, 6),
        new JdeField("VDTDPT", "VDTDPT", JdeDataType.String, 2),
        new JdeField("VDWIF", "VDWIF", JdeDataType.String, 2),
        new JdeField("VDWAF", "VDWAF", JdeDataType.String, 2),
        new JdeField("VDUSER", "VDUSER", JdeDataType.String, 20),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDJOBN", "VDJOBN", JdeDataType.String, 20),
        new JdeField("VDUPMJ", "VDUPMJ", JdeDataType.Numeric),
        new JdeField("VDTDAY", "VDTDAY", JdeDataType.Numeric),
        new JdeField("VDWAAVL", "VDWAAVL", JdeDataType.Numeric),
        new JdeField("VDCACR2", "VDCACR2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B72_0", "Primary Key on VDWOPID, VDWV2VLNID, VDWFTF, VDWBAD", new[] { "VDWOPID", "VDWV2VLNID", "VDWFTF", "VDWBAD" }, isUnique: true, isPrimaryKey: true)
    };
}
