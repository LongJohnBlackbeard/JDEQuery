using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B465 - .
/// </summary>
public class F03B465 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROSY.
        /// </summary>
        public const string ROSY = "ROSY";

        /// <summary>
        /// ROAN8.
        /// </summary>
        public const string ROAN8 = "ROAN8";

        /// <summary>
        /// ROKCO.
        /// </summary>
        public const string ROKCO = "ROKCO";

        /// <summary>
        /// RODCT.
        /// </summary>
        public const string RODCT = "RODCT";

        /// <summary>
        /// RODOC.
        /// </summary>
        public const string RODOC = "RODOC";

        /// <summary>
        /// ROSFX.
        /// </summary>
        public const string ROSFX = "ROSFX";

        /// <summary>
        /// ROVINV.
        /// </summary>
        public const string ROVINV = "ROVINV";

        /// <summary>
        /// ROVR01.
        /// </summary>
        public const string ROVR01 = "ROVR01";

        /// <summary>
        /// ROCTL.
        /// </summary>
        public const string ROCTL = "ROCTL";

        /// <summary>
        /// ROCO.
        /// </summary>
        public const string ROCO = "ROCO";

        /// <summary>
        /// ROMCU.
        /// </summary>
        public const string ROMCU = "ROMCU";

        /// <summary>
        /// RODGJ.
        /// </summary>
        public const string RODGJ = "RODGJ";

        /// <summary>
        /// RODIVJ.
        /// </summary>
        public const string RODIVJ = "RODIVJ";

        /// <summary>
        /// RODDNJ.
        /// </summary>
        public const string RODDNJ = "RODDNJ";

        /// <summary>
        /// RODDJ.
        /// </summary>
        public const string RODDJ = "RODDJ";

        /// <summary>
        /// ROSMTJ.
        /// </summary>
        public const string ROSMTJ = "ROSMTJ";

        /// <summary>
        /// RODSVJ.
        /// </summary>
        public const string RODSVJ = "RODSVJ";

        /// <summary>
        /// ROFY.
        /// </summary>
        public const string ROFY = "ROFY";

        /// <summary>
        /// ROCTRY.
        /// </summary>
        public const string ROCTRY = "ROCTRY";

        /// <summary>
        /// ROPN.
        /// </summary>
        public const string ROPN = "ROPN";

        /// <summary>
        /// ROGLC.
        /// </summary>
        public const string ROGLC = "ROGLC";

        /// <summary>
        /// ROPOST.
        /// </summary>
        public const string ROPOST = "ROPOST";

        /// <summary>
        /// ROPST.
        /// </summary>
        public const string ROPST = "ROPST";

        /// <summary>
        /// ROAG.
        /// </summary>
        public const string ROAG = "ROAG";

        /// <summary>
        /// ROAAP.
        /// </summary>
        public const string ROAAP = "ROAAP";

        /// <summary>
        /// ROCRR.
        /// </summary>
        public const string ROCRR = "ROCRR";

        /// <summary>
        /// ROCRRM.
        /// </summary>
        public const string ROCRRM = "ROCRRM";

        /// <summary>
        /// ROACR.
        /// </summary>
        public const string ROACR = "ROACR";

        /// <summary>
        /// ROFAP.
        /// </summary>
        public const string ROFAP = "ROFAP";

        /// <summary>
        /// ROCRCD.
        /// </summary>
        public const string ROCRCD = "ROCRCD";

        /// <summary>
        /// ROFNLP.
        /// </summary>
        public const string ROFNLP = "ROFNLP";

        /// <summary>
        /// RORP1.
        /// </summary>
        public const string RORP1 = "RORP1";

        /// <summary>
        /// RORP2.
        /// </summary>
        public const string RORP2 = "RORP2";

        /// <summary>
        /// RORP3.
        /// </summary>
        public const string RORP3 = "RORP3";

        /// <summary>
        /// ROAC01.
        /// </summary>
        public const string ROAC01 = "ROAC01";

        /// <summary>
        /// ROAC02.
        /// </summary>
        public const string ROAC02 = "ROAC02";

        /// <summary>
        /// ROAC03.
        /// </summary>
        public const string ROAC03 = "ROAC03";

        /// <summary>
        /// ROAC04.
        /// </summary>
        public const string ROAC04 = "ROAC04";

        /// <summary>
        /// ROAC05.
        /// </summary>
        public const string ROAC05 = "ROAC05";

        /// <summary>
        /// ROAC06.
        /// </summary>
        public const string ROAC06 = "ROAC06";

        /// <summary>
        /// ROAC07.
        /// </summary>
        public const string ROAC07 = "ROAC07";

        /// <summary>
        /// ROAC08.
        /// </summary>
        public const string ROAC08 = "ROAC08";

        /// <summary>
        /// ROAC09.
        /// </summary>
        public const string ROAC09 = "ROAC09";

        /// <summary>
        /// ROAC10.
        /// </summary>
        public const string ROAC10 = "ROAC10";

        /// <summary>
        /// ROAT1.
        /// </summary>
        public const string ROAT1 = "ROAT1";

        /// <summary>
        /// ROAT2.
        /// </summary>
        public const string ROAT2 = "ROAT2";

        /// <summary>
        /// ROAT3.
        /// </summary>
        public const string ROAT3 = "ROAT3";

        /// <summary>
        /// ROAT4.
        /// </summary>
        public const string ROAT4 = "ROAT4";

        /// <summary>
        /// ROAT5.
        /// </summary>
        public const string ROAT5 = "ROAT5";

        /// <summary>
        /// ROPYE.
        /// </summary>
        public const string ROPYE = "ROPYE";

        /// <summary>
        /// ROPYR.
        /// </summary>
        public const string ROPYR = "ROPYR";

        /// <summary>
        /// ROGLBA.
        /// </summary>
        public const string ROGLBA = "ROGLBA";

        /// <summary>
        /// ROAID2.
        /// </summary>
        public const string ROAID2 = "ROAID2";

        /// <summary>
        /// ROTNN.
        /// </summary>
        public const string ROTNN = "ROTNN";

        /// <summary>
        /// ROSHPN.
        /// </summary>
        public const string ROSHPN = "ROSHPN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B465";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROSY", "ROSY", JdeDataType.String, 8, true, true),
        new JdeField("ROAN8", "ROAN8", JdeDataType.Numeric),
        new JdeField("ROKCO", "ROKCO", JdeDataType.String, 10, true, true),
        new JdeField("RODCT", "RODCT", JdeDataType.String, 4, true, true),
        new JdeField("RODOC", "RODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ROSFX", "ROSFX", JdeDataType.String, 6, true, true),
        new JdeField("ROVINV", "ROVINV", JdeDataType.String, 50),
        new JdeField("ROVR01", "ROVR01", JdeDataType.String, 50),
        new JdeField("ROCTL", "ROCTL", JdeDataType.String, 26),
        new JdeField("ROCO", "ROCO", JdeDataType.String, 10),
        new JdeField("ROMCU", "ROMCU", JdeDataType.String, 24),
        new JdeField("RODGJ", "RODGJ", JdeDataType.Numeric),
        new JdeField("RODIVJ", "RODIVJ", JdeDataType.Numeric),
        new JdeField("RODDNJ", "RODDNJ", JdeDataType.Numeric),
        new JdeField("RODDJ", "RODDJ", JdeDataType.Numeric),
        new JdeField("ROSMTJ", "ROSMTJ", JdeDataType.Numeric),
        new JdeField("RODSVJ", "RODSVJ", JdeDataType.Numeric),
        new JdeField("ROFY", "ROFY", JdeDataType.Numeric),
        new JdeField("ROCTRY", "ROCTRY", JdeDataType.Numeric),
        new JdeField("ROPN", "ROPN", JdeDataType.Numeric),
        new JdeField("ROGLC", "ROGLC", JdeDataType.String, 8),
        new JdeField("ROPOST", "ROPOST", JdeDataType.String, 2),
        new JdeField("ROPST", "ROPST", JdeDataType.String, 2),
        new JdeField("ROAG", "ROAG", JdeDataType.Numeric),
        new JdeField("ROAAP", "ROAAP", JdeDataType.Numeric),
        new JdeField("ROCRR", "ROCRR", JdeDataType.Numeric),
        new JdeField("ROCRRM", "ROCRRM", JdeDataType.String, 2),
        new JdeField("ROACR", "ROACR", JdeDataType.Numeric),
        new JdeField("ROFAP", "ROFAP", JdeDataType.Numeric),
        new JdeField("ROCRCD", "ROCRCD", JdeDataType.String, 6),
        new JdeField("ROFNLP", "ROFNLP", JdeDataType.String, 2),
        new JdeField("RORP1", "RORP1", JdeDataType.String, 2),
        new JdeField("RORP2", "RORP2", JdeDataType.String, 2),
        new JdeField("RORP3", "RORP3", JdeDataType.String, 2),
        new JdeField("ROAC01", "ROAC01", JdeDataType.String, 6),
        new JdeField("ROAC02", "ROAC02", JdeDataType.String, 6),
        new JdeField("ROAC03", "ROAC03", JdeDataType.String, 6),
        new JdeField("ROAC04", "ROAC04", JdeDataType.String, 6),
        new JdeField("ROAC05", "ROAC05", JdeDataType.String, 6),
        new JdeField("ROAC06", "ROAC06", JdeDataType.String, 6),
        new JdeField("ROAC07", "ROAC07", JdeDataType.String, 6),
        new JdeField("ROAC08", "ROAC08", JdeDataType.String, 6),
        new JdeField("ROAC09", "ROAC09", JdeDataType.String, 6),
        new JdeField("ROAC10", "ROAC10", JdeDataType.String, 6),
        new JdeField("ROAT1", "ROAT1", JdeDataType.String, 6),
        new JdeField("ROAT2", "ROAT2", JdeDataType.String, 2),
        new JdeField("ROAT3", "ROAT3", JdeDataType.String, 2),
        new JdeField("ROAT4", "ROAT4", JdeDataType.String, 2),
        new JdeField("ROAT5", "ROAT5", JdeDataType.String, 2),
        new JdeField("ROPYE", "ROPYE", JdeDataType.Numeric),
        new JdeField("ROPYR", "ROPYR", JdeDataType.Numeric),
        new JdeField("ROGLBA", "ROGLBA", JdeDataType.String, 16),
        new JdeField("ROAID2", "ROAID2", JdeDataType.String, 16),
        new JdeField("ROTNN", "ROTNN", JdeDataType.String, 2),
        new JdeField("ROSHPN", "ROSHPN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B465_0", "Primary Key on ROSY, ROKCO, RODOC, RODCT, ROSFX", new[] { "ROSY", "ROKCO", "RODOC", "RODCT", "ROSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
