using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74YUI11 - .
/// </summary>
public class F74YUI11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDJOBS.
        /// </summary>
        public const string SDJOBS = "SDJOBS";

        /// <summary>
        /// SDN001.
        /// </summary>
        public const string SDN001 = "SDN001";

        /// <summary>
        /// SDIITY.
        /// </summary>
        public const string SDIITY = "SDIITY";

        /// <summary>
        /// SDTAX.
        /// </summary>
        public const string SDTAX = "SDTAX";

        /// <summary>
        /// SDTX2.
        /// </summary>
        public const string SDTX2 = "SDTX2";

        /// <summary>
        /// SDY74F4001.
        /// </summary>
        public const string SDY74F4001 = "SDY74F4001";

        /// <summary>
        /// SDY74F4002.
        /// </summary>
        public const string SDY74F4002 = "SDY74F4002";

        /// <summary>
        /// SDY74F5001.
        /// </summary>
        public const string SDY74F5001 = "SDY74F5001";

        /// <summary>
        /// SDY74F6001.
        /// </summary>
        public const string SDY74F6001 = "SDY74F6001";

        /// <summary>
        /// SDY74F7001.
        /// </summary>
        public const string SDY74F7001 = "SDY74F7001";

        /// <summary>
        /// SDY74F8001.
        /// </summary>
        public const string SDY74F8001 = "SDY74F8001";

        /// <summary>
        /// SDY74F9001.
        /// </summary>
        public const string SDY74F9001 = "SDY74F9001";

        /// <summary>
        /// SDY74F9002.
        /// </summary>
        public const string SDY74F9002 = "SDY74F9002";

        /// <summary>
        /// SDY74F1001.
        /// </summary>
        public const string SDY74F1001 = "SDY74F1001";

        /// <summary>
        /// SDY74F1101.
        /// </summary>
        public const string SDY74F1101 = "SDY74F1101";

        /// <summary>
        /// SDY74F1201.
        /// </summary>
        public const string SDY74F1201 = "SDY74F1201";

        /// <summary>
        /// SDY74F1301.
        /// </summary>
        public const string SDY74F1301 = "SDY74F1301";

        /// <summary>
        /// SDMATH01.
        /// </summary>
        public const string SDMATH01 = "SDMATH01";

        /// <summary>
        /// SDMATH02.
        /// </summary>
        public const string SDMATH02 = "SDMATH02";

        /// <summary>
        /// SDGPBT.
        /// </summary>
        public const string SDGPBT = "SDGPBT";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F74YUI11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDJOBS", "SDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SDN001", "SDN001", JdeDataType.Numeric, null, true, true),
        new JdeField("SDIITY", "SDIITY", JdeDataType.String, 2),
        new JdeField("SDTAX", "SDTAX", JdeDataType.String, 40),
        new JdeField("SDTX2", "SDTX2", JdeDataType.String, 40),
        new JdeField("SDY74F4001", "SDY74F4001", JdeDataType.Numeric),
        new JdeField("SDY74F4002", "SDY74F4002", JdeDataType.Numeric),
        new JdeField("SDY74F5001", "SDY74F5001", JdeDataType.Numeric),
        new JdeField("SDY74F6001", "SDY74F6001", JdeDataType.Numeric),
        new JdeField("SDY74F7001", "SDY74F7001", JdeDataType.Numeric),
        new JdeField("SDY74F8001", "SDY74F8001", JdeDataType.Numeric),
        new JdeField("SDY74F9001", "SDY74F9001", JdeDataType.Numeric),
        new JdeField("SDY74F9002", "SDY74F9002", JdeDataType.Numeric),
        new JdeField("SDY74F1001", "SDY74F1001", JdeDataType.Numeric),
        new JdeField("SDY74F1101", "SDY74F1101", JdeDataType.Numeric),
        new JdeField("SDY74F1201", "SDY74F1201", JdeDataType.Numeric),
        new JdeField("SDY74F1301", "SDY74F1301", JdeDataType.Numeric),
        new JdeField("SDMATH01", "SDMATH01", JdeDataType.Numeric),
        new JdeField("SDMATH02", "SDMATH02", JdeDataType.Numeric),
        new JdeField("SDGPBT", "SDGPBT", JdeDataType.Numeric),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74YUI11_0", "Primary Key on SDJOBS, SDN001", new[] { "SDJOBS", "SDN001" }, isUnique: true, isPrimaryKey: true)
    };
}
