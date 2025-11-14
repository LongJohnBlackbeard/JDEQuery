using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW61 - .
/// </summary>
public class FCW61 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIC9ITM.
        /// </summary>
        public const string SIC9ITM = "SIC9ITM";

        /// <summary>
        /// SIC9CAT1.
        /// </summary>
        public const string SIC9CAT1 = "SIC9CAT1";

        /// <summary>
        /// SIC9CAT2.
        /// </summary>
        public const string SIC9CAT2 = "SIC9CAT2";

        /// <summary>
        /// SIC9CAT3.
        /// </summary>
        public const string SIC9CAT3 = "SIC9CAT3";

        /// <summary>
        /// SIC9CAT4.
        /// </summary>
        public const string SIC9CAT4 = "SIC9CAT4";

        /// <summary>
        /// SIC9CAT5.
        /// </summary>
        public const string SIC9CAT5 = "SIC9CAT5";

        /// <summary>
        /// SIC9CAT6.
        /// </summary>
        public const string SIC9CAT6 = "SIC9CAT6";

        /// <summary>
        /// SIC9CAT7.
        /// </summary>
        public const string SIC9CAT7 = "SIC9CAT7";

        /// <summary>
        /// SIC9CAT8.
        /// </summary>
        public const string SIC9CAT8 = "SIC9CAT8";

        /// <summary>
        /// SIC9CAT9.
        /// </summary>
        public const string SIC9CAT9 = "SIC9CAT9";

        /// <summary>
        /// SIC9CAT0.
        /// </summary>
        public const string SIC9CAT0 = "SIC9CAT0";

        /// <summary>
        /// SIC9WASH.
        /// </summary>
        public const string SIC9WASH = "SIC9WASH";

        /// <summary>
        /// SIC9CHLO.
        /// </summary>
        public const string SIC9CHLO = "SIC9CHLO";

        /// <summary>
        /// SIC9IRON.
        /// </summary>
        public const string SIC9IRON = "SIC9IRON";

        /// <summary>
        /// SIC9DCLE.
        /// </summary>
        public const string SIC9DCLE = "SIC9DCLE";

        /// <summary>
        /// SIC9WRIN.
        /// </summary>
        public const string SIC9WRIN = "SIC9WRIN";

        /// <summary>
        /// SIC9SITM.
        /// </summary>
        public const string SIC9SITM = "SIC9SITM";

        /// <summary>
        /// SIC9MITM.
        /// </summary>
        public const string SIC9MITM = "SIC9MITM";

        /// <summary>
        /// SIC9TUSR.
        /// </summary>
        public const string SIC9TUSR = "SIC9TUSR";

        /// <summary>
        /// SIC9TITM.
        /// </summary>
        public const string SIC9TITM = "SIC9TITM";

        /// <summary>
        /// SIC9TMOD.
        /// </summary>
        public const string SIC9TMOD = "SIC9TMOD";

        /// <summary>
        /// SIURDT.
        /// </summary>
        public const string SIURDT = "SIURDT";

        /// <summary>
        /// SIURAT.
        /// </summary>
        public const string SIURAT = "SIURAT";

        /// <summary>
        /// SIURAB.
        /// </summary>
        public const string SIURAB = "SIURAB";

        /// <summary>
        /// SIURRF.
        /// </summary>
        public const string SIURRF = "SIURRF";

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
        /// SIUPMT.
        /// </summary>
        public const string SIUPMT = "SIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW61";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIC9ITM", "SIC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SIC9CAT1", "SIC9CAT1", JdeDataType.String, 20),
        new JdeField("SIC9CAT2", "SIC9CAT2", JdeDataType.String, 20),
        new JdeField("SIC9CAT3", "SIC9CAT3", JdeDataType.String, 20),
        new JdeField("SIC9CAT4", "SIC9CAT4", JdeDataType.String, 20),
        new JdeField("SIC9CAT5", "SIC9CAT5", JdeDataType.String, 20),
        new JdeField("SIC9CAT6", "SIC9CAT6", JdeDataType.String, 20),
        new JdeField("SIC9CAT7", "SIC9CAT7", JdeDataType.String, 20),
        new JdeField("SIC9CAT8", "SIC9CAT8", JdeDataType.String, 20),
        new JdeField("SIC9CAT9", "SIC9CAT9", JdeDataType.String, 20),
        new JdeField("SIC9CAT0", "SIC9CAT0", JdeDataType.String, 20),
        new JdeField("SIC9WASH", "SIC9WASH", JdeDataType.String, 2),
        new JdeField("SIC9CHLO", "SIC9CHLO", JdeDataType.String, 2),
        new JdeField("SIC9IRON", "SIC9IRON", JdeDataType.String, 2),
        new JdeField("SIC9DCLE", "SIC9DCLE", JdeDataType.String, 2),
        new JdeField("SIC9WRIN", "SIC9WRIN", JdeDataType.String, 2),
        new JdeField("SIC9SITM", "SIC9SITM", JdeDataType.Numeric),
        new JdeField("SIC9MITM", "SIC9MITM", JdeDataType.Numeric),
        new JdeField("SIC9TUSR", "SIC9TUSR", JdeDataType.String, 20),
        new JdeField("SIC9TITM", "SIC9TITM", JdeDataType.Numeric),
        new JdeField("SIC9TMOD", "SIC9TMOD", JdeDataType.String, 20),
        new JdeField("SIURDT", "SIURDT", JdeDataType.Numeric),
        new JdeField("SIURAT", "SIURAT", JdeDataType.Numeric),
        new JdeField("SIURAB", "SIURAB", JdeDataType.Numeric),
        new JdeField("SIURRF", "SIURRF", JdeDataType.String, 30),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW61_0", "Primary Key on SIC9ITM", new[] { "SIC9ITM" }, isUnique: true, isPrimaryKey: true)
    };
}
