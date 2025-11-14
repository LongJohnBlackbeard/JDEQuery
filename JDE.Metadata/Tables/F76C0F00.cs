using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0F00 - .
/// </summary>
public class F76C0F00 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STK74LECO.
        /// </summary>
        public const string STK74LECO = "STK74LECO";

        /// <summary>
        /// STC76SNDX.
        /// </summary>
        public const string STC76SNDX = "STC76SNDX";

        /// <summary>
        /// STC76DMCC.
        /// </summary>
        public const string STC76DMCC = "STC76DMCC";

        /// <summary>
        /// STC76FNAM.
        /// </summary>
        public const string STC76FNAM = "STC76FNAM";

        /// <summary>
        /// STC76WW1.
        /// </summary>
        public const string STC76WW1 = "STC76WW1";

        /// <summary>
        /// STC76WW2.
        /// </summary>
        public const string STC76WW2 = "STC76WW2";

        /// <summary>
        /// STC76WW3.
        /// </summary>
        public const string STC76WW3 = "STC76WW3";

        /// <summary>
        /// STC76WW4.
        /// </summary>
        public const string STC76WW4 = "STC76WW4";

        /// <summary>
        /// STC76MMCU.
        /// </summary>
        public const string STC76MMCU = "STC76MMCU";

        /// <summary>
        /// STC76F11C.
        /// </summary>
        public const string STC76F11C = "STC76F11C";

        /// <summary>
        /// STC76F12C.
        /// </summary>
        public const string STC76F12C = "STC76F12C";

        /// <summary>
        /// STC76F34C.
        /// </summary>
        public const string STC76F34C = "STC76F34C";

        /// <summary>
        /// STC76CMQ.
        /// </summary>
        public const string STC76CMQ = "STC76CMQ";

        /// <summary>
        /// STC76CFO.
        /// </summary>
        public const string STC76CFO = "STC76CFO";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0F00";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STK74LECO", "STK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("STC76SNDX", "STC76SNDX", JdeDataType.Numeric),
        new JdeField("STC76DMCC", "STC76DMCC", JdeDataType.Numeric),
        new JdeField("STC76FNAM", "STC76FNAM", JdeDataType.String, 2),
        new JdeField("STC76WW1", "STC76WW1", JdeDataType.String, 2),
        new JdeField("STC76WW2", "STC76WW2", JdeDataType.String, 2),
        new JdeField("STC76WW3", "STC76WW3", JdeDataType.String, 2),
        new JdeField("STC76WW4", "STC76WW4", JdeDataType.String, 2),
        new JdeField("STC76MMCU", "STC76MMCU", JdeDataType.String, 24),
        new JdeField("STC76F11C", "STC76F11C", JdeDataType.Numeric),
        new JdeField("STC76F12C", "STC76F12C", JdeDataType.Numeric),
        new JdeField("STC76F34C", "STC76F34C", JdeDataType.Numeric),
        new JdeField("STC76CMQ", "STC76CMQ", JdeDataType.String, 80),
        new JdeField("STC76CFO", "STC76CFO", JdeDataType.String, 80),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0F00_0", "Primary Key on STK74LECO", new[] { "STK74LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
