using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H512 - .
/// </summary>
public class F44H512 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSHBMCUS.
        /// </summary>
        public const string PSHBMCUS = "PSHBMCUS";

        /// <summary>
        /// PSHBLOT.
        /// </summary>
        public const string PSHBLOT = "PSHBLOT";

        /// <summary>
        /// PSOPKID.
        /// </summary>
        public const string PSOPKID = "PSOPKID";

        /// <summary>
        /// PSOPTION.
        /// </summary>
        public const string PSOPTION = "PSOPTION";

        /// <summary>
        /// PSOPPLB.
        /// </summary>
        public const string PSOPPLB = "PSOPPLB";

        /// <summary>
        /// PSOPGRP.
        /// </summary>
        public const string PSOPGRP = "PSOPGRP";

        /// <summary>
        /// PSGRPQ.
        /// </summary>
        public const string PSGRPQ = "PSGRPQ";

        /// <summary>
        /// PSTPQ.
        /// </summary>
        public const string PSTPQ = "PSTPQ";

        /// <summary>
        /// PSOPPVAL.
        /// </summary>
        public const string PSOPPVAL = "PSOPPVAL";

        /// <summary>
        /// PSCRTU.
        /// </summary>
        public const string PSCRTU = "PSCRTU";

        /// <summary>
        /// PSCRTJ.
        /// </summary>
        public const string PSCRTJ = "PSCRTJ";

        /// <summary>
        /// PSCRTT.
        /// </summary>
        public const string PSCRTT = "PSCRTT";

        /// <summary>
        /// PSWRKSTNID.
        /// </summary>
        public const string PSWRKSTNID = "PSWRKSTNID";

        /// <summary>
        /// PSHBOPID.
        /// </summary>
        public const string PSHBOPID = "PSHBOPID";

        /// <summary>
        /// PSUPMB.
        /// </summary>
        public const string PSUPMB = "PSUPMB";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";

        /// <summary>
        /// PSUPMT.
        /// </summary>
        public const string PSUPMT = "PSUPMT";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H512";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSHBMCUS", "PSHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("PSHBLOT", "PSHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("PSOPKID", "PSOPKID", JdeDataType.String, 16, true, true),
        new JdeField("PSOPTION", "PSOPTION", JdeDataType.String, 16, true, true),
        new JdeField("PSOPPLB", "PSOPPLB", JdeDataType.String, 40, true, true),
        new JdeField("PSOPGRP", "PSOPGRP", JdeDataType.Numeric, null, true, true),
        new JdeField("PSGRPQ", "PSGRPQ", JdeDataType.Numeric),
        new JdeField("PSTPQ", "PSTPQ", JdeDataType.Numeric),
        new JdeField("PSOPPVAL", "PSOPPVAL", JdeDataType.String, 60),
        new JdeField("PSCRTU", "PSCRTU", JdeDataType.String, 20),
        new JdeField("PSCRTJ", "PSCRTJ", JdeDataType.Numeric),
        new JdeField("PSCRTT", "PSCRTT", JdeDataType.Numeric),
        new JdeField("PSWRKSTNID", "PSWRKSTNID", JdeDataType.String, 20),
        new JdeField("PSHBOPID", "PSHBOPID", JdeDataType.String, 20),
        new JdeField("PSUPMB", "PSUPMB", JdeDataType.String, 20),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric),
        new JdeField("PSUPMT", "PSUPMT", JdeDataType.Numeric),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H512_0", "Primary Key on PSHBMCUS, PSHBLOT, PSOPKID, PSOPTION, PSOPPLB, PSOPGRP", new[] { "PSHBMCUS", "PSHBLOT", "PSOPKID", "PSOPTION", "PSOPPLB", "PSOPGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
