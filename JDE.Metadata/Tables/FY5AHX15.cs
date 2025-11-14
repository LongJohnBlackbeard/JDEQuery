using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX15 - .
/// </summary>
public class FY5AHX15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDY5AHE1RL.
        /// </summary>
        public const string SDY5AHE1RL = "SDY5AHE1RL";

        /// <summary>
        /// SDY5AHNTID.
        /// </summary>
        public const string SDY5AHNTID = "SDY5AHNTID";

        /// <summary>
        /// SDY5AHLNUM.
        /// </summary>
        public const string SDY5AHLNUM = "SDY5AHLNUM";

        /// <summary>
        /// SDY5AHMDID.
        /// </summary>
        public const string SDY5AHMDID = "SDY5AHMDID";

        /// <summary>
        /// SDY5AHNTTP.
        /// </summary>
        public const string SDY5AHNTTP = "SDY5AHNTTP";

        /// <summary>
        /// SDY5AHNGKY.
        /// </summary>
        public const string SDY5AHNGKY = "SDY5AHNGKY";

        /// <summary>
        /// SDY5AHTX02.
        /// </summary>
        public const string SDY5AHTX02 = "SDY5AHTX02";

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
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AHX15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDY5AHE1RL", "SDY5AHE1RL", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHNTID", "SDY5AHNTID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDY5AHLNUM", "SDY5AHLNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("SDY5AHMDID", "SDY5AHMDID", JdeDataType.String, 20),
        new JdeField("SDY5AHNTTP", "SDY5AHNTTP", JdeDataType.String, 2),
        new JdeField("SDY5AHNGKY", "SDY5AHNGKY", JdeDataType.String, 128),
        new JdeField("SDY5AHTX02", "SDY5AHTX02", JdeDataType.String, 200),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX15_0", "Primary Key on SDY5AHE1RL, SDY5AHNTID, SDY5AHLNUM", new[] { "SDY5AHE1RL", "SDY5AHNTID", "SDY5AHLNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
