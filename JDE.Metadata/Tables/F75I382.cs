using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I382 - .
/// </summary>
public class F75I382 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPYEXU.
        /// </summary>
        public const string IPYEXU = "IPYEXU";

        /// <summary>
        /// IPYRM.
        /// </summary>
        public const string IPYRM = "IPYRM";

        /// <summary>
        /// IPMNTH.
        /// </summary>
        public const string IPMNTH = "IPMNTH";

        /// <summary>
        /// IPUPMT.
        /// </summary>
        public const string IPUPMT = "IPUPMT";

        /// <summary>
        /// IPTRDJ.
        /// </summary>
        public const string IPTRDJ = "IPTRDJ";

        /// <summary>
        /// IPAA.
        /// </summary>
        public const string IPAA = "IPAA";

        /// <summary>
        /// IPAA1.
        /// </summary>
        public const string IPAA1 = "IPAA1";

        /// <summary>
        /// IPYPLBEDDR.
        /// </summary>
        public const string IPYPLBEDDR = "IPYPLBEDDR";

        /// <summary>
        /// IPYPLECDR.
        /// </summary>
        public const string IPYPLECDR = "IPYPLECDR";

        /// <summary>
        /// IPYPLSEDDR.
        /// </summary>
        public const string IPYPLSEDDR = "IPYPLSEDDR";

        /// <summary>
        /// IPYPLAEDDR.
        /// </summary>
        public const string IPYPLAEDDR = "IPYPLAEDDR";

        /// <summary>
        /// IPEDBT.
        /// </summary>
        public const string IPEDBT = "IPEDBT";

        /// <summary>
        /// IPI75MOPY.
        /// </summary>
        public const string IPI75MOPY = "IPI75MOPY";

        /// <summary>
        /// IPREMK.
        /// </summary>
        public const string IPREMK = "IPREMK";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPI75VNBR.
        /// </summary>
        public const string IPI75VNBR = "IPI75VNBR";

        /// <summary>
        /// IPEV01.
        /// </summary>
        public const string IPEV01 = "IPEV01";

        /// <summary>
        /// IPCUSTSUP.
        /// </summary>
        public const string IPCUSTSUP = "IPCUSTSUP";
    }

    /// <inheritdoc />
    public override string TableName => "F75I382";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPYEXU", "IPYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("IPYRM", "IPYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("IPMNTH", "IPMNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("IPUPMT", "IPUPMT", JdeDataType.Numeric),
        new JdeField("IPTRDJ", "IPTRDJ", JdeDataType.Numeric),
        new JdeField("IPAA", "IPAA", JdeDataType.Numeric),
        new JdeField("IPAA1", "IPAA1", JdeDataType.Numeric),
        new JdeField("IPYPLBEDDR", "IPYPLBEDDR", JdeDataType.Numeric),
        new JdeField("IPYPLECDR", "IPYPLECDR", JdeDataType.Numeric),
        new JdeField("IPYPLSEDDR", "IPYPLSEDDR", JdeDataType.Numeric),
        new JdeField("IPYPLAEDDR", "IPYPLAEDDR", JdeDataType.Numeric),
        new JdeField("IPEDBT", "IPEDBT", JdeDataType.String, 30, true, true),
        new JdeField("IPI75MOPY", "IPI75MOPY", JdeDataType.String, 60),
        new JdeField("IPREMK", "IPREMK", JdeDataType.String, 60),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPI75VNBR", "IPI75VNBR", JdeDataType.Numeric),
        new JdeField("IPEV01", "IPEV01", JdeDataType.String, 2),
        new JdeField("IPCUSTSUP", "IPCUSTSUP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I382_0", "Primary Key on IPYEXU, IPYRM, IPMNTH, IPEDBT", new[] { "IPYEXU", "IPYRM", "IPMNTH", "IPEDBT" }, isUnique: true, isPrimaryKey: true)
    };
}
